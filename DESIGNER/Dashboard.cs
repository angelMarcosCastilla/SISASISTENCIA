using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER
{
   public partial class Dashboard : Form
   {
        private Form formularioActual;
      public Dashboard()
      {
         InitializeComponent();
      }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
    }
}
