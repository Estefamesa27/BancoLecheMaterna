using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lechematerna2
{
    public partial class FrmDatosMadre : Form
    {
        public FrmDatosMadre()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                string TipoDocumento = cmbTipoDocumento.Text;
            int NumeroD = Int32.Parse(txtNumeroDocumento.Text);
            string Direccion = grpDireccion.Text;
            string Ciudad = txtCiudad.Text;
            int Telefono = Int32.Parse(txtTelefono.Text);
            //DateTime FNacimiento = dtFechaNacimiento.Checked;
            Double Peso = Double.Parse(txtPeso.Text);
            Double Talla = Double.Parse(txtTalla.Text);
            Double IMC = Double.Parse(txtIMC.Text);
            bool SI = rdSi.Checked;
            bool NO = rdNo.Checked;
            bool si = rdSi2.Checked;
            bool no = rdNo2.Checked;
            //DateTime FRegla = dtRegla.Text;
            // DateTime FParto = dtParto.Text;
            int Amenorrea = Int32.Parse(txtEdadAmenorrea.Text);
            string PatologíaEmbarazo = txtPatologia.Text;

            DateTime Date = DateTime.UtcNow.Date;


            bool error = false;
            string errores = string.Empty;


            ErrorMadre.SetError(cmbTipoDocumento, null);
            if (string.IsNullOrEmpty(TipoDocumento))
            {
                ErrorMadre.SetError(cmbTipoDocumento, "Ingrese el tipo de documento de la madre");
                errores += "Tipo de documento; ";
                error = true;
            }

            //ErrorMadre.SetError(txtNumeroDocumento, null);
            //if (string.IsNullOrEmpty(NumeroD))
            //{
            //    ErrorMadre.SetError(txtNumeroDocumento, "Ingrese el número de documento de la madre");
            //    errores += "Número de documento; ";
            //    error = true;
            //}

            ErrorMadre.SetError(txtCiudad, null);
            if (string.IsNullOrEmpty(Ciudad))
            {
                ErrorMadre.SetError(txtCiudad, "Ingrese la ciudad de residencia de la madre");
                errores += "Ciudad; ";
                error = true;
            }

            //ErrorMadre.SetError(txtTelefono, null);
            //if (string.IsNullOrEmpty(Telefono))
            //{
            //    ErrorMadre.SetError(txtTelefono, "Ingrese el teléfono de la madre");
            //    errores += "Teléfono; ";
            //    error = true;
            //}

            ErrorMadre.SetError(dtFechaNacimiento, null);
            if (dtFechaNacimiento.Checked == false)
            {
                ErrorMadre.SetError(dtFechaNacimiento, "Ingrese la fecha de nacimiento de la madre");
                errores += "Fecha de nacimiento; ";
                error = false;
            }

            //ErrorMadre.SetError(txtPeso, null);
            //if (string.IsNullOrEmpty(Peso))
            //{
            //    ErrorMadre.SetError(txtPeso, "Ingrese el peso de la madre");
            //    errores += "Peso; ";
            //    error = true;
            //}

            //ErrorMadre.SetError(txtTalla, null);
            //if (string.IsNullOrEmpty(Talla))
            //{
            //    ErrorMadre.SetError(txtTalla, "Ingrese la talla del busto de la madre");
            //    errores += "Talla; ";
            //    error = true;
            //}

            //ErrorMadre.SetError(txtIMC, null);
            //if (string.IsNullOrEmpty(IMC))
            //{
            //    ErrorMadre.SetError(txtIMC, "Ingrese el IMC de la madre");
            //    errores += "IMC; ";
            //    error = true;
            //}

            ErrorMadre.SetError(dtRegla, null);
            if (dtRegla.Checked == false)
            {
                ErrorMadre.SetError(dtRegla, "Ingrese la fecha de la última regla de la madre");
                errores += "Fecha última regla; ";
                error = true;
            }

            ErrorMadre.SetError(dtParto, null);
            if (dtParto.Checked == false)
            {
                ErrorMadre.SetError(dtParto, "Ingrese la fecha de parto de la madre");
                errores += "Fecha del parto; ";
                error = true;
            }

            ErrorMadre.SetError(txtEdadAmenorrea, null);
            //if (Int32.isnull(Amenorrea))
            //{
            //    ErrorMadre.SetError(txtEdadAmenorrea, "Ingrese la edad de amenorrea de la madre");
            //    errores += "Edad amenorrea; ";
            //    error = true;
            //}

            ErrorMadre.SetError(txtPatologia, null);
            if (string.IsNullOrEmpty(PatologíaEmbarazo))
            {
                ErrorMadre.SetError(txtPatologia, "Ingrese patología/s en el embarazo de la madre");
                errores += "Patología en embarazo; ";
                error = true;
            }

            if (!error)
                
            {
                string connetionString = null;
                string sql = null;
                SqlCommand sqlCommand = null;


                SqlConnection cnn;
                connetionString = "Data Source=(local);Initial Catalog=BancoLecheMaterna;User ID=BancoLecheMaterna; Password=BancoLecheMaterna";
                cnn = new SqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    sql = "Insert into DatosMadre (TipoDocumento, NúmeroDocumento, Dirección, Ciudad,Teléfono, FechaNacimietno," +
                        " Peso, Talla, IMC, UsaMedicamentos, TieneHabitosToxicos, FechaÚltimaRegla, FechaParto, EdadAmenorrea, " +
                        "PatologíaEmbarazo) VALUES ('" + TipoDocumento + "'," + NumeroD + ",'jijh','" + Ciudad + "'," + Telefono + 
                        ",'" + DateTime.UtcNow.ToString("MM-dd-yyyy") + "'," + Peso + "," + Talla +  
                        "," + IMC + "," + 1 + "," + 1 + ",'" + DateTime.UtcNow.ToString("MM-dd-yyyy") +
                        "','" + DateTime.UtcNow.ToString("MM-dd-yyyy") + "'," + Amenorrea + ",'" + PatologíaEmbarazo + "')";
                  sqlCommand= new SqlCommand(sql, cnn);
                    sqlCommand.ExecuteNonQuery();                    
                    MessageBox.Show("Registro Exitoso");
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error al guardar: "+ex.Message);
                }
                finally
                {
                    sqlCommand.Dispose();
                    cnn.Close();
                }
            }
            else
            { 
                MessageBox.Show("Debe llenar todos los espacios:  \n" + errores);
        }
        


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ocultar el formulario activo
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtFechaNacimiento.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede seleccionar una fecha futura", "Error de" +
                    "ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaOpciones frm = new FrmListaOpciones();
            frm.Show();
        }

        private void dtRegla_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtRegla.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede seleccionar una fecha futura", "Error de" +
                    "ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtParto_ValueChanged(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Today;
            if (dtParto.Value.Date >= hoy)
            {
                MessageBox.Show("Fecha inválida, no puede seleccionar una fecha futura", "Error de" +
                    "ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroDocumento_KeyPress_1(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTelefono_KeyPress_2(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPeso_KeyPress_3(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEdadAmenorrea_KeyPress_4(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDocBuscar_KeyPress_5(Object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
}
    }
}
}
