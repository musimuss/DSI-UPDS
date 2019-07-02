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
    public partial class FrmPagosReg : Form
    {
        private int id_;
        modelo.Pagos pagos = new modelo.Pagos();
        bool ver = false;

        
        public FrmPagosReg(modelo.Fraterno f)
        {
            InitializeComponent();
            id_ = f.id;
            lEstado.Text = "";
        }
        public void refresh()
        {
            dataGridView1.DataSource = pagos.Select(id_,General.conexion);
        }
        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bMarcar_Click(object sender, EventArgs e)
        {
            decimal i;
            decimal.TryParse(tbMonto.Text, out i);
            pagos.acuenta = i;
            pagos.fecha = dateTimePicker1.Value;
            ver = pagos.Add(General.conexion);
            if (ver)
            {
                lEstado.Text = "REGISTRO CORRECTO...";

            }
            else
                lEstado.Text = "No se puede registro.  " + General.conexion.error;
        }

        private void FrmPagosReg_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
