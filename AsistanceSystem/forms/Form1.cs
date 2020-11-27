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
        private  EmpleadoFill _EmpleadoFill;
        public Form1()
        {
            InitializeComponent();
            _EmpleadoFill = new EmpleadoFill();
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
            if (captureDevice.IsRunning)
                captureDevice.Stop();
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
                DateTime hora = Convert.ToDateTime("2008-12-24 09:40:00");
                if (txtCapture.Text == classEmpleados.CodigoEmpleado)
                {
                    classAsistencia.CodigoEmpleado = txtCapture.Text;
                    classAsistencia.HoraDeEntrada = hora;

                }

                _EmpleadoFill.SaveAsistent(classAsistencia);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
           

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            login formLogin= new login();
            formLogin.Show();
        }
    }
}
        