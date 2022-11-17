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
    public partial class frmMotivossalida : Form
    {
        MotivosSalidas motivo = new MotivosSalidas();

        bool buscar = false;
        public frmMotivossalida()
        {
            InitializeComponent();
        }

        private void ckbuscar_CheckedChanged(object sender, EventArgs e)
        {
            buscar = !buscar;
            if (buscar)
            {
                txtBuscarMotivo.Enabled= true;
                btnGuardarMotivo.Enabled=false;
                btnEditarMotivo.Enabled = true;
                
            }
            else
            {
                txtBuscarMotivo.Enabled = false;
                btnGuardarMotivo.Enabled = true;
                btnEditarMotivo.Enabled = false;
                
            }
        }

        public void listarMotivos()
        {
            gridMotivossalida.DataSource = motivo.ListarMotivosSalida();
            gridMotivossalida.Refresh();
        }

        private void frmMotivossalida_Load(object sender, EventArgs e)
        {
            listarMotivos();
        }

        private void btnGuardarMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                string motivosalida = txtMotivoSalida.Text;
                motivo.registrarMotivosSalida(motivosalida);
                listarMotivos();
                txtMotivoSalida.Text = "";
            }
            catch
            {
                MessageBox.Show("No se pudo guardar");
            }
        }

        private void txtBuscarMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int idmotivo = Convert.ToInt16(txtBuscarMotivo.Text);
                DataTable datos = motivo.buscarMotivosSalidas(idmotivo);
                if (datos.Rows.Count > 0)
                {
                    txtMotivoSalida.Text = datos.Rows[0]["motivosalida"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro registro");
                }
            }
        }

        private void btnEditarMotivo_Click(object sender, EventArgs e)
        {
            try
            {
                int idmotivosalida = Convert.ToInt16(txtBuscarMotivo.Text);
                string motivosalida = txtMotivoSalida.Text;
                motivo.editarMotivosSalidas(motivosalida, idmotivosalida);
                listarMotivos();
                txtBuscarMotivo.Text = "";
            }
            catch
            {
                MessageBox.Show("No se pudo editar");
            }
        }
    }
}
