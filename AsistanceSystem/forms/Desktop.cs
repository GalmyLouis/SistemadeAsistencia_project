using AsistanceSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistanceSystem.forms
{
    
    public partial class DesktopForm : Form
    {
        
        private EmpleadoFill _EmpleadoFill;//clase EmpleadoFill tienes metodos de funcionamiento
        public DesktopForm()
        {
            InitializeComponent();
            _EmpleadoFill = new EmpleadoFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarQr codigoQr = new generarQr();
            codigoQr.Show();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            CargarAsistencia();
        }
        //permite Mostrar asistencia 
        public void CargarAsistencia()
        {
            List<ClassAsistencia> classAsistencia = _EmpleadoFill.GetAsistencia();
            DgAsistencia.DataSource = classAsistencia;
        }

        
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            agregar saveEmp = new agregar();
            saveEmp.ShowDialog();
        }

       

   
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportesAs rpt = new ReportesAs();
            rpt.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void iconBtnAgregarE_Click(object sender, EventArgs e)
        //{
        //    agregar saveEmp = new agregar();
        //    saveEmp.ShowDialog();
        //}




    }
}
