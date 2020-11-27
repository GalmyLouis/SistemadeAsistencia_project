
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
        private ClassEmpleados _classEmpleados;

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
            //var vad = txtCodigo.Text = txtNombre.Text =
            //    txtApellido.Text = txtDireccion.Text = txtCedula.Text
            //    = txtEmail.Text = txtCargo.Text = txtTelefono.Text;

            //if (vad == "")
            //{
            //    MessageBox.Show("Hay uno o varios campos vacios");
            //}
            //else
            //{
             
                GuardarEmpleado();
                this.Close();
                ((agregar)this.Owner).CargarEmpleado();
            //}
        }

       
        private void GuardarEmpleado()
        {
            ClassEmpleados classEmpleados = new ClassEmpleados();
            classEmpleados.id = _classEmpleados != null ? _classEmpleados.id : 0;
            classEmpleados.CodigoEmpleado = txtCodigo.Text;
            classEmpleados.Nombre = txtNombre.Text;
            classEmpleados.Apellido = txtApellido.Text;
            classEmpleados.Cedula = txtCedula.Text;
            classEmpleados.Direccion = txtDireccion.Text;
            classEmpleados.Email = txtEmail.Text;
            classEmpleados.Cargo = txtCargo.Text;
            classEmpleados.Telefono = txtTelefono.Text;

            classEmpleados.id = _classEmpleados != null ? _classEmpleados.id : 0;
            //if (_classEmpleados != null)
            //{
            //    classEmpleados.id = _classEmpleados.id;
            //}
            //else
            //{
            //    classEmpleados.id = 0;

            //}
            _EmpleadoFill.SaveEmployes(classEmpleados);
        }
        public void LoadEmpleado (ClassEmpleados classEmpleados)
        {
            _classEmpleados = classEmpleados;
            if(classEmpleados != null)
            {
                Limpiar();
                txtCodigo.Text=classEmpleados.CodigoEmpleado;
                txtNombre.Text = classEmpleados.Nombre ;
                txtApellido.Text= classEmpleados.Apellido;
                txtCedula.Text= classEmpleados.Cedula;
                txtDireccion.Text= classEmpleados.Direccion;
                txtEmail.Text= classEmpleados.Email;
                txtCargo.Text= classEmpleados.Cargo;
                txtTelefono.Text= classEmpleados.Telefono;
            }
        }

        public void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text =string.Empty;
            txtCargo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
