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
        public Login()
        {
            InitializeComponent();
        }

      private void btnLogin_Click(object sender, EventArgs e)
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
            if(clave == claveAcceso)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
