using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AsistanceSystem.forms
{
    public partial class generarQr : Form
    {
        System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
             
        public generarQr()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw codigoQr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgQr.Image = codigoQr.Draw(txtGenerar.Text, 40);
        }

        private void btnSaveQr_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "JPEG|*.jpeg";

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                string waring = saveFileDialog.FileName;
                Bitmap bitmap = new Bitmap(imgQr.Image);
                bitmap.Save(waring, ImageFormat.Jpeg);
            }

        }

        private void generarQr_Load(object sender, EventArgs e)
        {

        }
    }
}
