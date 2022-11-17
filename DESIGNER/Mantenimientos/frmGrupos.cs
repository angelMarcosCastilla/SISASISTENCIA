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
    public partial class frmGrupos : Form
    {
        Grupo grupo = new Grupo();

        bool buscar = false;
        char turno = 'M';
        public frmGrupos()
        {
            InitializeComponent();
        }

        private void btnGuardarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                int grado = Convert.ToInt16(txtGrado.Text);
                string seccion = txtSeccion.Text;
                grupo.registrarGrupos(grado, seccion, turno);
                listarGrupos();
                limpiarFormulario();
             }
             catch
            {
                 MessageBox.Show("Error al guardar el grupo");
            }
        }


        private void frmGrupos_Load(object sender, EventArgs e)
        {
            listarGrupos();
        }

        public void listarGrupos()
        {
            gridGrupos.DataSource = grupo.ListarGruposActivos();
            gridGrupos.Refresh();
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            turno = 'M';
        }

        private void rbtnT_CheckedChanged(object sender, EventArgs e)
        {
            turno = 'T';
        }

        public void limpiarFormulario()
        {
            txtGrado.Text = "";
            txtSeccion.Text = "";
            rbtnM.Checked = true;
            rbtnT.Checked = false;
        }

        private void txtBuscarGrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int idgrupo = Convert.ToInt16(txtBuscarGrupos.Text);
                DataTable datos = grupo.buscarGrupo(idgrupo);
                if (datos.Rows.Count > 0)
                {
                    bool estado = Convert.ToBoolean(datos.Rows[0]["estado"].ToString());
                    if (estado)
                    {
                        txtGrado.Text = datos.Rows[0]["grado"].ToString();
                        txtSeccion.Text = datos.Rows[0]["seccion"].ToString();
                        string turno = datos.Rows[0]["turno"].ToString();
                        if (turno == "M")
                        {
                            rbtnM.Checked = true;
                        }
                        else
                        {
                            rbtnT.Checked = true;
                        }
                    }
                    else
                    {
                        if (preguntar("¿El grupo esta inactivo desea activarlo?") == DialogResult.Yes)
                        {
                            grupo.activarGrupo(idgrupo);
                            listarGrupos();
                            txtGrado.Text = datos.Rows[0]["grado"].ToString();
                            txtSeccion.Text = datos.Rows[0]["seccion"].ToString();
                            string turno = datos.Rows[0]["turno"].ToString();
                            if (turno == "M")
                            {
                                rbtnM.Checked = true;
                            }
                            else
                            {
                                rbtnT.Checked = true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro grupo");
                }
            }

        }

        private void ckbuscar_CheckedChanged(object sender, EventArgs e)
        {
            buscar = !buscar;
            if (buscar)
            {
                txtBuscarGrupos.Enabled= true;
                btnGuardarGrupos.Enabled= false;
                btnEliminarGrupos.Enabled = true;
                btnEditarGrupos.Enabled = true;
            }
            else
            {
                txtBuscarGrupos.Enabled= false;
                btnEliminarGrupos.Enabled = false;
                btnEditarGrupos.Enabled = false;
                btnGuardarGrupos.Enabled = true;
            }
        }

        private void btnEditarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                int idgrupo = Convert.ToInt16(txtBuscarGrupos.Text);
                int grado = Convert.ToInt16(txtGrado.Text);
                string seccion = txtSeccion.Text;
                grupo.editarGrupos(grado, seccion, turno, idgrupo);
                listarGrupos();
                limpiarFormulario();
                txtBuscarGrupos.Text = "";
            }
            catch
            {
                MessageBox.Show("No se pudo editar");
            }
        }

        private void btnEliminarGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                int idgrupo = Convert.ToInt16(txtBuscarGrupos.Text);
                grupo.eliminarGrupo(idgrupo);
                limpiarFormulario();
                listarGrupos();
                txtBuscarGrupos.Text = "";
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private DialogResult preguntar(string textoPregunta)
        {
            return MessageBox.Show(textoPregunta, "Sistema de cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
    }
}
