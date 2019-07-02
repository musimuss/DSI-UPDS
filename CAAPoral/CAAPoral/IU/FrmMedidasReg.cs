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
    public partial class FrmMedidasReg : Form
    {
        bool ver = false;
        private int id_f;
        modelo.Medida medida = new modelo.Medida();
        public FrmMedidasReg(modelo.Fraterno f)
        {
            InitializeComponent();
            id_f = f.persona.id;
            if (medida.Registro(id_f, General.conexion) > 0)
            {
                tbTorso.Text = medida.torso.ToString();
                tbCintura.Text = medida.cintura.ToString();
                tbBrazos.Text = medida.brazos.ToString();
                tbPiernas.Text = medida.piernas.ToString();
                tbZapato.Text = medida.zapato.ToString();
                tbCabeza.Text = medida.cabeza.ToString();
            }
        }

        private void bCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            decimal m,n,o,p,q,r;
            decimal.TryParse(tbTorso.Text, out m);
            decimal.TryParse(tbCintura.Text, out n);
            decimal.TryParse(tbBrazos.Text, out o);
            decimal.TryParse(tbPiernas.Text, out p);
            decimal.TryParse(tbZapato.Text, out q);
            decimal.TryParse(tbCabeza.Text, out r);
            medida.torso = m;
            medida.cintura = n;
            medida.brazos = o;
            medida.piernas = p;
            medida.zapato = q;
            medida.cabeza = r;
            medida.id_fraterno = id_f;
            if (medida.Registro(id_f,General.conexion)>0)
            {
                ver = medida.Add(General.conexion);
                if (ver)
                {
                    lbmsg.Text = "INGRESO CORRECTO";
                }
                else
                {
                    ver = medida.Edit(General.conexion);
                    if (ver)
                        lbmsg.Text = "INGRESO CORRECTO";
                    else
                        lbmsg.Text = "ERROR...";
                }
            }
            else
            {
                ver = medida.Add(General.conexion);
                if (ver)
                {
                    lbmsg.Text = "INGRESO CORRECTO";
                }
                else
                {
                    ver = medida.Edit(General.conexion);
                    if (ver)
                        lbmsg.Text = "INGRESO CORRECTO";
                    else
                        lbmsg.Text = "ERROR...";
                }
            }
        }
    }
}
