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
    public partial class Principal : Form
    {
        
        public Principal()
        {
            

            InitializeComponent();
        }

      

        private void iconBtnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }
        public void cargarpanel()
        {

            panelPrincipal.Controls.Clear();
            DesktopForm desktop = new DesktopForm();
            desktop.TopLevel = false;
            panelPrincipal.Controls.Add(desktop);
            desktop.Dock = DockStyle.Fill;
            desktop.Show();
        }

        public void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconBtnScanear_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Form1 frm= new Form1();
            frm.TopLevel = false;
            panelPrincipal.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void iconBtnEmpleados_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            agregar agreg = new agregar();
            agreg.TopLevel = false;
            panelPrincipal.Controls.Add(agreg);
            agreg.Dock = DockStyle.Fill;
            agreg.Show();
        }

        private void iconBtnReportes_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ReportesAs reportes = new ReportesAs();
            reportes.TopLevel = false;
            panelPrincipal.Controls.Add(reportes);
            reportes.Dock = DockStyle.Fill;
            reportes.Show();
        }

        private void iconBtnAsistencia_Click(object sender, EventArgs e)
        {
            cargarpanel();
        }


        private void iconBtnGenerarQr_Click(object sender, EventArgs e)
        {
            generarQr codigoQr = new generarQr();
            panelPrincipal.Controls.Clear();
            codigoQr.TopLevel = false;
            panelPrincipal.Controls.Add(codigoQr);
            codigoQr.Dock = DockStyle.Fill;
            codigoQr.Show();
        }

        private void iconBtnSignIn_Click_1(object sender, EventArgs e)
        {
            var Result= MessageBox.Show("Estas Seguro de cerrar Sesion","Presionar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (Result != DialogResult.No)
                this.Close();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            iconScanearQR.Visible = false;
        }
    }
}
