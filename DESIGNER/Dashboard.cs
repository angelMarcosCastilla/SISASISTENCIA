using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DESIGNER.Mantenimientos;
namespace DESIGNER
{
   public partial class Dashboard : Form
   {
        private Form formularioActual;
      public Dashboard(string nombresuario)
      {
         InitializeComponent();
          lbluserInfo.Text = " " + nombresuario;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPersonas());
            activarMenuActivo("persona");
            
        }
        
        private void OpenChildForm(Form childForm)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = childForm;
            formularioActual.TopLevel = false;
            formularioActual.FormBorderStyle = FormBorderStyle.None;
            formularioActual.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPersonas());
            activarMenuActivo("persona");
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmUsuarios());
            activarMenuActivo("usuario");
        }

        private void btnMotivo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMotivossalida());
            activarMenuActivo("motivo");
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGrupos());
            activarMenuActivo("grupo");
        }

        private void activarMenuActivo(string menuActivo)
        {
            btnPersonas.BackColor = Color.Transparent;
            btnUsuario.BackColor = Color.Transparent;
            btnMotivo.BackColor = Color.Transparent;
            btnGrupos.BackColor = Color.Transparent;
            btnAsistencia.BackColor = Color.Transparent;
            btnmatricula.BackColor = Color.Transparent;
            if (menuActivo == "persona")
             {
                    btnPersonas.BackColor = Color.FromArgb(0, 122, 104);
             }
            else if (menuActivo == "usuario")
             {
                    btnUsuario.BackColor = Color.FromArgb(0, 122, 104);
             }
            else if (menuActivo == "motivo")
             {
                    btnMotivo.BackColor = Color.FromArgb(0, 122, 104);
             }
            else if (menuActivo == "grupo")
             {
                    btnGrupos.BackColor = Color.FromArgb(0, 122, 104);
             }
            else if(menuActivo == "asistencia")
            {
                btnAsistencia.BackColor = Color.FromArgb(0, 122, 104);
            }else if (menuActivo == "matricula")
            {
                btnmatricula.BackColor = Color.FromArgb(0, 122, 104);
            }
        }

        private void btnCerrasSession_Click(object sender, EventArgs e)
        {
            // cerrar session
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
