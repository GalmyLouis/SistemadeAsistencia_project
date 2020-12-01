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
    
    public partial class Desktop : Form
    {
        
        private EmpleadoFill _EmpleadoFill;//clase EmpleadoFill tienes metodos de funcionamiento
        public Desktop()
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

        //aqui llamamos El formulario de Agregar Empleados
        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            agregar saveEmp = new agregar();
            saveEmp.ShowDialog();
        }

        //aqui permite Cerrar Sesion
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estas seguro de cerrar sesion", MessageBoxButtons.OK.ToString());
            this.Close();
        }

        //aqui permite Abrir Ventana de Reportes
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportesAs rpt = new ReportesAs();
            rpt.ShowDialog();
        }
    }
}
