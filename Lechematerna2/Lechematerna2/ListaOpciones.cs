using System;
using System.Windows.Forms;

namespace Lechematerna2
{
    public partial class FrmListaOpciones : Form
    {
        public FrmListaOpciones()
        {
            InitializeComponent();
        }

        private void bttnSALIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void bttnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIniciarPrograma frm = new FrmIniciarPrograma();
            frm.Show();
        }

        private void bttnDatosMadre_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDatosMadre frm = new FrmDatosMadre();
            frm.Show();
        }

        private void bttnDatosDonacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDatosDonacion frm = new FrmDatosDonacion();
            frm.Show();
        }
    }
}
