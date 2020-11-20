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
            try
            {
                string conex = ConfigurationManager.ConnectionStrings["conex"].ConnectionString;
                using (SqlConnection connection=new SqlConnection(conex))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(" Select [Clave_usuario],[access] From administrador " 
                        + "Where [Clave_usuarios]="+ txtUsers+"And [access]="+ txtAccess+"", connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("logged");
                        }
                        else
                        {
                            MessageBox.Show("errorr, user or password not verified ");
                        }
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void txtAccept_Click(object sender, EventArgs e)
        {
          
            desktop.Show();
           
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
