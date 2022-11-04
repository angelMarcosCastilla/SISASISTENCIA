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
namespace DESIGNER.Mantenimientos
{
    public partial class FrmPersonas : Form
    {
        Persona persona = new Persona();
        char sexo = 'M';
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            listarPersonas();
        }

        public void listarPersonas()
        {
            gridPersona.DataSource = persona.listarPersonas();
            gridPersona.Refresh();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            string dni = txtDni.Text;
            string celular = txtCelular.Text;
            string fechaNacimiento = txtFechaNacimiento.Text;
            string direccion = txtDireccion.Text;
            string email = txtEmail.Text;

            try {

                persona.registrarPersona(nombres, apellidos, dni, celular, fechaNacimiento, direccion, email, sexo);
            }
            catch
            {
                MessageBox.Show("Error al registrar persona");
            }
            
        }

        private void rdbHombre_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 'M';
        }

        private void rdbMujer_CheckedChanged(object sender, EventArgs e)
        {
            sexo = 'F';
        }
    }
}
