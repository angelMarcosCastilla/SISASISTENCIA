using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
namespace DESIGNER
{
    public partial class Login : Form
    {
         Usuario usuario = new Usuario();
        bool mostrar = false;
        public Login()
        {
            InitializeComponent();
        }

      private void btnLogin_Click(object sender, EventArgs e)
      {
            try
            {

                DataTable resultado = new DataTable();
                string nombreUsuario = txtEmail.Text;
                string claveAcceso = txtPassword.Text;
                lblErrorClaveAcceso.Text = "";
                lblErrorNombreUsuario.Text = "";
                resultado = usuario.login(nombreUsuario);

                if (resultado.Rows.Count > 0)
                {
                    // falta encriptar
                    string clave = resultado.Rows[0][2].ToString();
                    if (clave == claveAcceso)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblErrorClaveAcceso.Text = "Clave de accesso incorrecto !!!";
                    }
                }
                else
                {
                    lblErrorNombreUsuario.Text = "Nombre de usuario incorrecto !!!";
                }
            }
            catch
            {
                MessageBox.Show("Error al iniciar sesión");
            }
      }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mostrar = !mostrar;
            if (mostrar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
