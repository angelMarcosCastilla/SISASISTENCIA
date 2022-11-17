using BOL;
using CryptSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Mantenimientos
{
    public partial class FrmUsuarios : Form
    {
        bool buscar = false;
        Usuario usuario = new Usuario();
        Persona persona = new Persona();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ckbuscar_CheckedChanged(object sender, EventArgs e)
        {
            buscar = !buscar;
            if (buscar)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtBuscarUsuario.Enabled = true;
               
            }
            else
            {
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                txtBuscarUsuario.Enabled = false;
                lblClaveAccesso.Text = "Clave Acceso";
                llblHelp.Text = "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreusuario = txtnombreusuario.Text;
                string claveacceso = txtclaveacceso.Text;
                int idpersona = Convert.ToInt16(txtidpersona.Text);
                string  claveEncriptada = Crypter.Blowfish.Crypt(claveacceso);
                
                // verificamos si el id de la persona esta activa
                DataTable datosPersonas = persona.buscarPersona(idpersona);

                if (datosPersonas.Rows.Count > 0)
                {
                    bool estado = Convert.ToBoolean(datosPersonas.Rows[0]["estado"].ToString()); 
                    if (!estado)
                    {
                        if (preguntar("la persona esta inactiva , ¿Deseas Activarla?") != DialogResult.Yes) return;
                        persona.activarPersona(idpersona);
                        usuario.registrarUsuarios(idpersona, claveEncriptada, nombreusuario);
                    }
                    else
                    {
                        usuario.registrarUsuarios(idpersona, claveEncriptada, nombreusuario);
                    }

                    listarUsuarios();
                    limpiarform();
                }
                else
                {
                    MessageBox.Show("el id de la persona no existe");
                } 
            } catch{
                MessageBox.Show("Error al agregar usuario");
            }
        }


        public void listarUsuarios()
        {
            gridUsuario.DataSource = usuario.listarUsuariosActivos();
            gridUsuario.Refresh();
        }
        
        private DialogResult preguntar(string textoPregunta)
        {
            return MessageBox.Show(textoPregunta, "Sistema de cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void limpiarform()
        {
            txtnombreusuario.Text = "";
            txtclaveacceso.Text = "";
            txtidpersona.Text = "";
            txtBuscarUsuario.Text = "";
            txtidpersona.ReadOnly = false;
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            listarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idusuario = Convert.ToInt16(txtBuscarUsuario.Text);
                if (preguntar("¿Desea eliminar el usuario?") == DialogResult.Yes)
                {
                    usuario.eliminarUsuario(idusuario);
                    listarUsuarios();
                    limpiarform();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar usuario");
            }
        }

        private void txtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // dar enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int idusuario = Convert.ToInt16(txtBuscarUsuario.Text);
                    DataTable datosUsuario = usuario.buscarUsuarios(idusuario);
                    if (datosUsuario.Rows.Count > 0)
                    {

                        bool estado = Convert.ToBoolean(datosUsuario.Rows[0]["estado"].ToString());
                        string claveEncriptada = datosUsuario.Rows[0]["claveacceso"].ToString();
                        if (!estado)
                        {
                            if (preguntar("El usuario esta inactivo, ¿Desea activarlo?") == DialogResult.Yes)
                            {
                                usuario.activarUsuario(idusuario);
                                listarUsuarios();
                                txtnombreusuario.Text = datosUsuario.Rows[0]["nombreusuario"].ToString();
                                txtidpersona.ReadOnly = true;
                                lblClaveAccesso.Text = "Nueva Clave de Acceso";
                                llblHelp.Text = "Deje en blanco sino quieres cambiar la clave";
                                txtidpersona.Text = datosUsuario.Rows[0]["idpersona"].ToString();
                            }
                        }
                        else
                        {
                            txtnombreusuario.Text = datosUsuario.Rows[0]["nombreusuario"].ToString();
                            txtidpersona.ReadOnly = true;
                            lblClaveAccesso.Text = "Nueva Clave de Acceso";
                            llblHelp.Text = "Deje en blanco sino quieres cambiar la clave";
                            txtidpersona.Text = datosUsuario.Rows[0]["idpersona"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                }
                catch
                {
                    MessageBox.Show("Error al buscar usuario");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
