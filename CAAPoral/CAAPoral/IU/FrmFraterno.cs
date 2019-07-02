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
    public partial class FrmFraterno : Form
    {
        modelo.Fraterno fraterno=new modelo.Fraterno();
        public FrmFraterno()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            dataGridView1.DataSource = fraterno.Select(General.conexion);
        }
        private void FrmFraterno_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void Tbusuario_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fraterno.Select(tbusuario.Text,General.conexion);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmFraternoForm fr = new FrmFraternoForm(new modelo.Fraterno());
            fr.ShowDialog();
            refresh();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                modelo.Fraterno f = dataGridView1.CurrentRow.DataBoundItem as modelo.Fraterno;
                FrmFraternoForm form = new FrmFraternoForm(f,true);
                form.ShowDialog();
                refresh();
            }
            catch (Exception ee) { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ESTA SEGURO DE ELIMINAR?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                fraterno = dataGridView1.CurrentRow.DataBoundItem as modelo.Fraterno;
                if (fraterno.Delete(General.conexion))
                {
                    ssEstado.Text = "Dato Eliminado...";
                    refresh();
                }
                else
                {
                    ssEstado.Text = "Error en el proceso, " + General.conexion.error;
                }
            }
        }
    }
}
