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
    public partial class generarQr : Form
    {
        public generarQr()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.CodeQrBarcodeDraw codigoQr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
           // imgQr.Image = codigoQr.Draw(txtGenerar.Text, 40);
        }

        private void btnSaveQr_Click(object sender, EventArgs e)
        {
           /* SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SaveFileDialog.FileName = "";
            SaveFileDialog.Filter = "png|*.png";*/

        }

        private void generarQr_Load(object sender, EventArgs e)
        {

        }
    }
}
