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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DESIGNER.Mantenimientos
{
    public partial class frmAsistencia : Form
    {
        Asistencia asistencia = new Asistencia();
        Persona persona = new Persona();
        MotivosSalidas mtsalida = new MotivosSalidas();
        char ingreso = 'E';
        int idmatricula = 0;
        int id = 0;
        public frmAsistencia(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void limpiarform()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            cbMotivo.Text = "";
            txtDescripcion.Text = "";
            txtBuscarPersona.Text = "";
            idmatricula = 0;
        }
        public void listarAsistencias()
        {
            gridAsistencia.DataSource = asistencia.listarMatriculasActivas();
            gridAsistencia.Refresh();
        }
        private void txtBuscarPerssona_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si presiono enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int id = Convert.ToInt16(txtBuscarPersona.Text);
                    DataTable data = asistencia.registrarAsistenciaGeneral(id);
                    if (data.Rows.Count > 0)
                    {
                        txtNombres.Text = data.Rows[0]["nombres"].ToString();
                        txtApellidos.Text = data.Rows[0]["apellidos"].ToString();
                        txtDni.Text = data.Rows[0]["dni"].ToString();
                        idmatricula = Convert.ToInt16(data.Rows[0]["idmatricula"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("El estudiante no se encuentra matriculado");
                        idmatricula=0;
                    }

                }
                catch
                {
                    MessageBox.Show("Error Al Buscar Persona");
                }
            }
        }

        private void btnRegistrarAsistencia_Click(object sender, EventArgs e)
        {


            if (ingreso == 'E')
            {
                asistencia.registrarAsistenciaEntrada(idmatricula);
                idmatricula = 0;
                listarAsistencias();
                limpiarform();
            }
            else
            {
                DataTable data = asistencia.buscarUltimaAsistencia(idmatricula);
                int idasistencia = Convert.ToInt16(data.Rows[0]["idasistencia"].ToString());
                int index = cbMotivo.Text.IndexOf(' ');
                int idmotivo = index>0? Convert.ToInt16(cbMotivo.Text.Substring(0, index)):0;
                if (idmotivo > 0)
                {

                    asistencia.registrarAsistenciaSalida(id, "Z", idmotivo, txtDescripcion.Text, idmatricula, idasistencia);
                    listarAsistencias();
                    limpiarform();
                }
                else 
                {
                    asistencia.registrarAsistenciaSalida(id, "", 0, "", idmatricula, idasistencia);
                    listarAsistencias();
                    limpiarform();
                }

            }
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ingreso = 'E';
            lblDescripcion.Visible = false;
            lblMotivo.Visible = false;
            cbMotivo.Visible = false;
            txtDescripcion.Visible = false;
        }

        private void rbSalida_CheckedChanged(object sender, EventArgs e)
        {
            ingreso = 'S';
            lblDescripcion.Visible = true;
            lblMotivo.Visible = true;
            cbMotivo.Visible = true;
            txtDescripcion.Visible = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            listarAsistencias();
            DataTable data = mtsalida.ListarMotivosSalida();
            cbMotivo.DisplayMember = "Text";
            cbMotivo.ValueMember = "Value";
            
            for (int i=0; i<data.Rows.Count;i++)
            {
                int idmotivo = Convert.ToInt16(data.Rows[i]["idmotivo"].ToString());
                cbMotivo.Items.Add(new { Text = idmotivo + " " +  data.Rows[i]["motivosalida"].ToString(), Value = idmotivo});
            }
        }

        private void cbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
