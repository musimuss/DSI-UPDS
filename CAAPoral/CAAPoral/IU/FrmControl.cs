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
    public partial class FrmControl : Form
    {
        private DateTime fecha_;
        modelo.Asistencia asistencia = new modelo.Asistencia();
        bool ver = false;
        public FrmControl(DateTime fecha)
        {
            InitializeComponent();
            fecha_ = fecha;
            lEstado.Text = "";
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bMarcar_Click(object sender, EventArgs e)
        {
            int i;
            int.TryParse(tbId.Text, out i);
            asistencia.id_fraterno = i;
            asistencia.fecha = fecha_;
            ver = asistencia.Add(General.conexion);
            if (ver)
            {
                lEstado.Text = "REGISTRO CORRECTO...";
                
            }
            else
                lEstado.Text = "No se puede registro.  " + General.conexion.error;
        }
    }
}
