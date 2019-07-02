using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo;

namespace CAAPoral.IU
{
    public partial class FrmAsistencia : Form
    {
        modelo.Asistencia asistencia = new modelo.Asistencia();
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = asistencia.Select(dtpFecha.Value, General.conexion);
            dgvDatos.Columns["id"].Visible = false;
            dgvDatos.Columns["id_fraterno"].Visible = false;
            dgvDatos.Columns["id1"].Visible = false;
            dgvDatos.Columns["cel"].Visible = false;
            dgvDatos.Columns["estado"].Visible = false;
            dgvDatos.Columns["id2"].Visible = false;
        }
    }
}
