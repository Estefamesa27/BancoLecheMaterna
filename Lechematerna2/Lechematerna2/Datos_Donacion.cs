using System;
using System.Windows.Forms;

namespace Lechematerna2
{
    public partial class FrmDatosDonacion : Form
    {
        public FrmDatosDonacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Etiquetado = txtEtiquetado.Text;
            bool Recoleccion = dtRecoleccion.Checked;
            string Registro = txtRegistro.Text;
            string Codigo = txtCodigoRecipiente.Text;
            string Cantidad = txtCantidadLeche.Text;
            bool Vencimiento = dtVencimiento.Checked;

            bool error = false;
            string errores = string.Empty;
            

            erpError.SetError(txtEtiquetado, null);
            if (string.IsNullOrEmpty(Etiquetado))
            {
                erpError.SetError(txtEtiquetado, "Ingrese el etiquetado del recipiente");
                errores += "Etiquetado; ";
                error = true;
            }

            erpError.SetError(dtRecoleccion, null);
            if (dtRecoleccion.Checked == false)
            {
                erpError.SetError(dtRecoleccion, "Ingrese la fecha de recolección del recipiente");
                errores += "Fecha de recoleccion; ";
                error = true;
            }                     

            erpError.SetError(txtRegistro, null);
            if (string.IsNullOrEmpty(Registro))
            {
                erpError.SetError(txtRegistro, "Ingrese el registro del recipiente");
                errores += "Registro; ";
                error = true;
            }

            erpError.SetError(txtCodigoRecipiente, null);
            if (string.IsNullOrEmpty(Codigo))
            {
                erpError.SetError(txtCodigoRecipiente, "Ingrese el código del recipiente");
                errores += "ID del recipiente; ";
                error = true;
            }

            erpError.SetError(txtCantidadLeche, null);
            if (string.IsNullOrEmpty(Cantidad))
            {
                erpError.SetError(txtCantidadLeche, "Ingrese la cantidad de leche del recipiente");
                errores += "Cantidad de leche donada; ";
                error = true;
            }
                        
            erpError.SetError(dtVencimiento, null);
            if (dtVencimiento.Checked == false)
            {
                erpError.SetError(dtVencimiento, "Ingrese la fecha de vencimiento del recipiente");
                errores += "Fecha de vencimiento; ";
                error = true;
            }

            if (!error)
                MessageBox.Show("Se ha registrado con éxito");
            else
                MessageBox.Show("Debe llenar todos los espacios:  \n" + errores);             
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            Close();
        }

        private void Datos_Donacion_Load(object sender, EventArgs e)
        {

        }

        private void bttnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaOpciones frm = new FrmListaOpciones();
            frm.Show();
        }

        private void dtFechaRecoleccion_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtRecoleccion.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede seleccionar una fecha futura", "Error de" +
                    "ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtVencimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtVencimiento.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede seleccionar una fecha futura", "Error de" +
                    "ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRegistro_KeyPress_1(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigoRecipiente_KeyPress_2(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
