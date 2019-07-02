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
    public partial class FrmLogin : Form
    {
        public bool login { get; set; }
        public FrmLogin()
        {
            InitializeComponent();
            login = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbmsg.Text = "Verificando.......";
            Application.DoEvents();
            modelo.Usuario user = new modelo.Usuario();
            user.login = tbusuario.Text.Trim();
            user.password= tbpassword.Text;

            login=user.islogin(General.conexion);
            if (login)
                this.Close();
            else {
                lbmsg.Text = "Usuario incorrecto";
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
