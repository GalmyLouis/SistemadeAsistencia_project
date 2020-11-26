
using AsistanceSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistanceSystem.forms
{
    public partial class agregar : Form
    {
        private EmpleadoFill _EmpleadoFill;
        public agregar()
        {
            InitializeComponent();
            _EmpleadoFill = new EmpleadoFill();
        }

        private void agregar_Load(object sender, EventArgs e)
        {
            CargarEmppleado();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenNuevoEmpleado();
                 
        }

        private void OpenNuevoEmpleado()
        {
            NuevoEmpleado nuevoE = new NuevoEmpleado();
            nuevoE.ShowDialog(this);
        }
        #region Events
        private void btnModificar_Click(object sender, EventArgs e)
        {
            

        }
        #endregion
        public void CargarEmppleado()
        {
            List<ClassEmpleados> classEmpleados = _EmpleadoFill.GetEmpleados();
            dgEmpleado.DataSource = classEmpleados;    
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
