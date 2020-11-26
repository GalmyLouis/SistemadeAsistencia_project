
using AsistanceSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistanceSystem.forms
{
    public partial class NuevoEmpleado : Form
    {

        private EmpleadoFill _EmpleadoFill;
        

        public NuevoEmpleado()
        {
            InitializeComponent();
            _EmpleadoFill = new EmpleadoFill();
        }

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {
    //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var vad = txtCodigo.Text = txtNombre.Text =
                txtApellido.Text = txtDireccion.Text = txtCedula.Text
                = txtEmail.Text = txtCargo.Text = txtTelefono.Text;

            if (vad == "")
            {
                MessageBox.Show("Hay uno o varios campos vacios");
            }
            else
            {
             
                GuardarEmpleado();
                this.Close();
                ((agregar)this.Owner).CargarEmppleado();
            }
        }

       
        private void GuardarEmpleado()
        {
            ClassEmpleados classEmpleados = new ClassEmpleados();
            classEmpleados.CodigoEmpleado = txtCodigo.Text;
            classEmpleados.Nombre = txtNombre.Text;
            classEmpleados.Apellido = txtApellido.Text;
            classEmpleados.Cedula = txtCedula.Text;
            classEmpleados.Direccion = txtDireccion.Text;
            classEmpleados.Email = txtEmail.Text;
            classEmpleados.Cargo = txtCargo.Text;
            classEmpleados.Telefono = txtTelefono.Text;

            _EmpleadoFill.SaveEmployes(classEmpleados);
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
