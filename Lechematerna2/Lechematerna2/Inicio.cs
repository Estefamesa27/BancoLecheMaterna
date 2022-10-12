using System;
using System.Windows.Forms;

namespace Lechematerna2
{
    public partial class FrmIniciarPrograma : Form
    {
        public FrmIniciarPrograma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresarprograma_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }

            FrmListaOpciones frm = new FrmListaOpciones();

            this.Hide();
            frm.ShowDialog();
        }

        private bool ValidarDatos()
        {


            bool correcto = true;
            if (txbUsuario.Text.ToLower() != "hospitalusuario")
            {
                rrrPrvdrIniciar.SetError(txbUsuario, "Usuario Incorrecto");
                correcto = false;
            }
            else
            {
                rrrPrvdrIniciar.SetError(txbUsuario, "");

            }

            if (tbxContraseña.Text != "000")
            {
                rrrPrvdrIniciar.SetError(tbxContraseña, "Contraseña Incorrecta");
                correcto = false;
            }
            else
            {
                rrrPrvdrIniciar.SetError(tbxContraseña, "");
            }
            return correcto;
        
        }

        private void tbxContraseña_TextChanged(object sender, EventArgs e)
        {
            {
                if (tbxContraseña.PasswordChar == (char)0)
                    tbxContraseña.PasswordChar = '*';
                else
                    tbxContraseña.PasswordChar = (char)0;
            }
        }

        private void UsuarioTxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


