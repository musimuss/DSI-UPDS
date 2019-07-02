using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAAPoral.IU
{
    public partial class FrmPagos : Form
    {
        modelo.Fraterno fraterno = new modelo.Fraterno();
        public FrmPagos()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            dgvDatos.DataSource = fraterno.Select(General.conexion);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                modelo.Fraterno f = dgvDatos.CurrentRow.DataBoundItem as modelo.Fraterno;
                FrmPagosReg form = new FrmPagosReg(f);
                form.ShowDialog();
                refresh();
            }
            catch (Exception ee) { }
        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = fraterno.Select(tbusuario.Text, General.conexion);
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
