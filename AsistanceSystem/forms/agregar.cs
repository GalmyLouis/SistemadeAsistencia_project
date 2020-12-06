
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
            CargarEmpleado();
        }

        private void iconBtnNuevoE_Click(object sender, EventArgs e)
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
        public void CargarEmpleado()
        {
            List<ClassEmpleados> classEmpleados = _EmpleadoFill.GetEmpleados();
            dgEmpleado.DataSource = classEmpleados;    
        }
        private void iconCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void dgEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dgEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                NuevoEmpleado nuevoEmpleado = new NuevoEmpleado();
                nuevoEmpleado.LoadEmpleado(new ClassEmpleados
                {
                    id = int.Parse(dgEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    CodigoEmpleado = dgEmpleado.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Nombre = dgEmpleado.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Apellido = dgEmpleado.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Cedula = dgEmpleado.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Direccion = dgEmpleado.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Email = dgEmpleado.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    Cargo = dgEmpleado.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    Telefono = dgEmpleado.Rows[e.RowIndex].Cells[8].Value.ToString()
                });
                nuevoEmpleado.ShowDialog(this);

            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                deleteEmpleados(int.Parse(dgEmpleado.Rows[e.RowIndex].Cells[0].Value.ToString()));
                CargarEmpleado();
            }
                
        }
        private void deleteEmpleados(int id)
        {
            _EmpleadoFill.deleteEmpleados(id);
        }
    }
}
