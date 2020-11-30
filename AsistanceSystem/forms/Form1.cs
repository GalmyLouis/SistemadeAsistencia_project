using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Windows.Forms;
using ZXing;
using ZXing.Multi;
using AsistanceSystem.forms;
using System.Runtime.Remoting.Contexts;
using AsistanceSystem.Class;

namespace AsistanceSystem
{
    public partial class Form1 : Form
    {
        private DataAccess _dataAccess;
        private  EmpleadoFill _EmpleadoFill;
        public Form1()
        {
            InitializeComponent();
            _EmpleadoFill = new EmpleadoFill();
            _dataAccess=new DataAccess();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo filterInfo in filterInfoCollection)
            {
                cbFilter.Items.Add(filterInfo.Name);
            }
            cbFilter.SelectedIndex = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice= new VideoCaptureDevice(filterInfoCollection[cbFilter.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            txtCapture.Text = " ";
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbScanner.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoCaptureDevice captureDevice = new VideoCaptureDevice();
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
            else
            {
                MessageBox.Show("Adios");
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbScanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbScanner.Image);
                if(result!=null)
                {
                    txtCapture.Text = result.ToString();
                   
                    MessageBox.Show(txtCapture.Text);
                    guardarAsistencia();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();


                }
            }

        }



        public void guardarAsistencia()
        {
            try
            {
                ClassEmpleados classEmpleados = new ClassEmpleados();
                ClassAsistencia classAsistencia = new ClassAsistencia();
               var datos = _dataAccess.GetCodigoEmpleado();
                
                    foreach (var item in datos)
                    {
                        var id = item.CodigoEmpleado;
                        if (id == txtCapture.Text)
                        {
                            DateTime hora = DateTime.Now;
                            classAsistencia.CodigoEmpleado = txtCapture.Text;
                            classAsistencia.HoraDeEntrada = hora;
                            _EmpleadoFill.SaveAsistent(classAsistencia);
                        }else if(id == txtCapture.Text)
                        {
                        MessageBox.Show("Usted no es Empleado de la empresa O sus datos aun no esta en nuestra base de datos");

                        }

                    }

                                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
           

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            login formLogin= new login();
            formLogin.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        