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
        bool esBuscar = false;
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
            gridPersona.DataSource = persona.listarPersonaActivas();
            gridPersona.Refresh();
        }

        public void limpiarFormulario()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            txtCelular.Text = "";
            txtFechaNacimiento.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtBuscarPerssona.Text = "";
            rdbHombre.Checked = true;
            rdbMujer.Checked = false;
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

                persona.registrarPersona(nombres, apellidos, dni, fechaNacimiento, direccion, email, celular, sexo);
                listarPersonas();
                limpiarFormulario();
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

        private void txtBuscarPerssona_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si presiono enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int id = Convert.ToInt16(txtBuscarPerssona.Text);
                    DataTable resultado = persona.buscarPersona(id);
                    // ver si hay datos en resultado
                    if(resultado.Rows.Count > 0)
                    {
                        bool estado = Convert.ToBoolean(resultado.Rows[0]["estado"].ToString());
                        if (estado)
                        {
                            
                            txtNombres.Text = resultado.Rows[0]["nombres"].ToString();
                            txtApellidos.Text = resultado.Rows[0]["apellidos"].ToString();
                            txtDireccion.Text = resultado.Rows[0]["direccion"].ToString();
                            txtDni.Text = resultado.Rows[0]["dni"].ToString();
                            txtCelular.Text = resultado.Rows[0]["celular"].ToString();
                            txtEmail.Text = resultado.Rows[0]["email"].ToString();
                            txtFechaNacimiento.Text = resultado.Rows[0]["fechanacimiento"].ToString();
                            string sexoData = resultado.Rows[0]["sexo"].ToString();
                            if (sexoData == "M")
                            {
                                rdbHombre.Checked = true;
                                rdbMujer.Checked = false;
                                sexo = 'M';
                            }
                            else
                            {
                                rdbHombre.Checked = false;
                                rdbMujer.Checked = true;
                                sexo = 'F';
                            }
                            txtNombres.Focus();
                        }
                        else
                        {
                            if(preguntar("La persona esta inactiva deseas Activarla ?") == DialogResult.Yes)
                            {
                                
                                persona.activarPersona(id);
                                listarPersonas();

                                txtNombres.Text = resultado.Rows[0]["nombres"].ToString();
                                txtApellidos.Text = resultado.Rows[0]["apellidos"].ToString();
                                txtDireccion.Text = resultado.Rows[0]["direccion"].ToString();
                                txtDni.Text = resultado.Rows[0]["dni"].ToString();
                                txtCelular.Text = resultado.Rows[0]["celular"].ToString();
                                txtEmail.Text = resultado.Rows[0]["email"].ToString();
                                txtFechaNacimiento.Text = resultado.Rows[0]["fechanacimiento"].ToString();
                                string sexoData = resultado.Rows[0]["sexo"].ToString();
                                if (sexoData == "M")
                                {
                                    rdbHombre.Checked = true;
                                    rdbMujer.Checked = false;
                                    sexo = 'M';
                                }
                                else
                                {
                                    rdbHombre.Checked = false;
                                    rdbMujer.Checked = true;
                                    sexo = 'F';
                                }
                                txtNombres.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }
                    
                }
                catch {
                    MessageBox.Show("Error Al Buscar Persona");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(txtBuscarPerssona.Text);
                persona.eliminarPersona(id);
                listarPersonas();
                limpiarFormulario();
            }
            catch
            {
                MessageBox.Show("Error al eliminar Persona");
            }
        }

        private void ckbuscar_CheckedChanged(object sender, EventArgs e)
        {
            esBuscar = !esBuscar;
            txtBuscarPerssona.Enabled = esBuscar;
            btnEditar.Enabled = esBuscar;
            btnEliminar.Enabled = esBuscar;
            btnRegistrar.Enabled = !esBuscar;
            limpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string dni = txtDni.Text;
                string celular = txtCelular.Text;
                string fechaNacimiento = txtFechaNacimiento.Text;
                string direccion = txtDireccion.Text;
                string email = txtEmail.Text;
                int id = Convert.ToInt16(txtBuscarPerssona.Text);

                persona.editarPersona(nombres, apellidos, dni, fechaNacimiento, direccion, email, celular, sexo, id);
                listarPersonas();
                limpiarFormulario();
            }
            catch
            {
                MessageBox.Show("error Al Editar Persona");
            }
        }
        private DialogResult preguntar(string textoPregunta)
        {
            return MessageBox.Show(textoPregunta, "Sistema de cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
