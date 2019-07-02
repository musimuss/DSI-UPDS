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
    public partial class FrmFraternoForm : Form
    {
        bool edit = false;
        modelo.Fraterno fraterno = new modelo.Fraterno();
        public FrmFraternoForm(modelo.Fraterno f,bool edit=false)
        {
            InitializeComponent();
            fraterno = f;
            this.edit = edit;
            if (edit) {
                tbnombre.Text = f.persona.nombre;
                tbapellidos.Text = f.persona.apellidos;
                tbci.Text = f.persona.ci;
                tbci.Text = f.persona.ci;
                tbcel.Text = f.cel.ToString();
                switch (f.bloque) {
                    case modelo.Fraterno.Bloques.Cholita1:
                        rbcholita.Checked = true;
                        break;
                    case modelo.Fraterno.Bloques.fachas:
                        rbfachas.Checked = true;
                        break;
                    case modelo.Fraterno.Bloques.Tigritos:
                        rbtigitos.Checked = true;
                        break;
                    case modelo.Fraterno.Bloques.Tiguresas:
                        rbtigresas.Checked = true;
                        break;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                fraterno = new modelo.Fraterno();
                fraterno.persona = new modelo.Persona();
            }
            fraterno.persona.nombre = tbnombre.Text;
            fraterno.persona.apellidos = tbapellidos.Text;
            fraterno.persona.ci = tbci.Text;
            long cel = 0;
            long.TryParse(tbcel.Text, out cel);
            fraterno.cel = cel;
            fraterno.bloque = rbcholita.Checked ? modelo.Fraterno.Bloques.Cholita1 :
                rbfachas.Checked ? modelo.Fraterno.Bloques.fachas :
                rbtigitos.Checked ? modelo.Fraterno.Bloques.Tigritos :
                
                modelo.Fraterno.Bloques.Tiguresas;
            bool ver = false;
            if (edit)
            {

                fraterno.persona.Edit(General.conexion);
                ver=fraterno.Edit(General.conexion);

            }
            else
            {
                fraterno.persona.Add(General.conexion);
                ver=fraterno.Add(General.conexion);
            }
            if (ver)
                this.Close();
            else
                this.lbmsg.Text ="No se puede guardar datos.  "+ General.conexion.error;
        }
    }
}
