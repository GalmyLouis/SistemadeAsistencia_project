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
        public Desktop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generarQr codigoQr = new generarQr();
            codigoQr.Show();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            agregar saveEmp = new agregar();
            saveEmp.ShowDialog();
        }
    }
}
