using BOL;
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
    public partial class frmMatricula : Form
    {
        Matricula matricula = new Matricula();
        Persona persona = new Persona();
        Grupo grupo = new Grupo();
        
        public frmMatricula()
        {
            InitializeComponent();
        }
        public void listarMatriculados()
        {
            gridMatricula.DataSource = matricula.listarMatriculas();
            gridMatricula.Refresh();
        }
        private void limpiarform()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            txtGrado.Text = "";
            txtSeccion.Text = "";
        }
        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int idgrupo = Convert.ToInt16(txtGrupo.Text);
                DataTable datos = grupo.buscarGrupo(idgrupo);
                if (datos.Rows.Count > 0)
                {
                    bool estado = Convert.ToBoolean(datos.Rows[0]["estado"].ToString());
                    if (estado)
                    {
                        txtGrado.Text = datos.Rows[0]["grado"].ToString();
                        txtSeccion.Text = datos.Rows[0]["seccion"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro grupo");
                }
            }
        }

        private void txtBuscarPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si presiono enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int id = Convert.ToInt16(txtIdPersona.Text);
                    DataTable resultado = persona.buscarPersona(id);
                    // ver si hay datos en resultado
                    if (resultado.Rows.Count > 0)
                    {
                        bool estado = Convert.ToBoolean(resultado.Rows[0]["estado"].ToString());
                        if (estado)
                        {
                            txtNombres.Text = resultado.Rows[0]["nombres"].ToString();
                            txtApellidos.Text = resultado.Rows[0]["apellidos"].ToString();
                            txtDni.Text = resultado.Rows[0]["dni"].ToString();
                            //txtGrado.Text = resultado.Rows[0]["grado"].ToString();
                            //txtSeccion.Text = resultado.Rows[0]["seccion"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }

                }
                catch
                {
                    MessageBox.Show("Error Al Buscar Persona");
                }
            }
        }

        private void btnRegistrarMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                
                int idpersona = Convert.ToInt32(txtIdPersona.Text);
                int idgrupo = Convert.ToInt32(txtGrupo.Text);
                matricula.registrarMatricula(idpersona,idgrupo);
                listarMatriculados();
                limpiarform();
            }
            catch
            {
                MessageBox.Show("Error al registrar la matrícula");
            }
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            listarMatriculados();
        }
    }
}
