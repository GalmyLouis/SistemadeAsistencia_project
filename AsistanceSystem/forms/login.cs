using AsistanceSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistanceSystem.forms
{
    public partial class login : Form
    {
        Desktop desktop = new Desktop();
        public login()
        {
            InitializeComponent();
        }

        

        private void txtAccept_Click(object sender, EventArgs e)
        {
            //string spassword = Encrypt.GetSHA256( txtAccess.Text);
            string spassword = txtAccess.Text;
            string clave = txtUsers.Text;
            /*using (Models.AsistenciaEntities3 db =new Models.AsistenciaEntities3())
            {
                var lst = db.tblAdministrador.FirstOrDefault(d => d.Usuario == clave);
                          
                         
                if (lst!=null)
                {
                    if (lst.Access == spassword)
                    {
                        MessageBox.Show("logged");
                        this.Hide();
                        desktop.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Usuario no existe ");
                }
            }

           */
           
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
