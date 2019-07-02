using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAAPoral
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            FrmLogin loga = new FrmLogin();
            loga.ShowDialog();
            if (!loga.login) {
               this.Close();
                return;
            }

            
            lbUser.Text = string.Format("{0} {1}", General.user.persona.nombre, General.user.persona.apellidos);
            
        }
        private void bFraternos_Click(object sender, EventArgs e)
        {
            IU.FrmFraterno f = new IU.FrmFraterno();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(f);
            f.Show();
        }

        private void bMedidas_Click(object sender, EventArgs e)
        {
            IU.FrmMedidas f = new IU.FrmMedidas();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(f);
            f.Show();
        }

        private void bPagos_Click(object sender, EventArgs e)
        {
            IU.FrmPagos f = new IU.FrmPagos();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(f);
            f.Show();
        }

        private void bAsistencia_Click(object sender, EventArgs e)
        {
            IU.FrmAsistencia f = new IU.FrmAsistencia();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(f);
            f.Show();
        }

        private void bControl_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtpControl.Value;
            IU.FrmControl f = new IU.FrmControl(fecha);
            f.ShowDialog();
        }
        private void bLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DESEA FINALIZAR EL PROGRAMA?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
