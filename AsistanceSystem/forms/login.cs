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
        private DataAccess _dataAccess;
        public login()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }


        
        private void txtAccept_Click(object sender, EventArgs e)
        {
            
            ClassLogin classLogin = new ClassLogin();
            classLogin.Usuario = txtUsers.Text;
            classLogin.contrasena = txtAccess.Text;

            _dataAccess.login(classLogin);
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
