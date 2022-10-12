using System;
using System.Windows.Forms;

namespace Lechematerna2
{
    partial class FrmDatosMadre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.grpDatosAgrupados = new System.Windows.Forms.GroupBox();
            this.grpMedicamentos = new System.Windows.Forms.GroupBox();
            this.rdSi = new System.Windows.Forms.RadioButton();
            this.rdNo = new System.Windows.Forms.RadioButton();
            this.grpHabitos = new System.Windows.Forms.GroupBox();
            this.rdSi2 = new System.Windows.Forms.RadioButton();
            this.rdNo2 = new System.Windows.Forms.RadioButton();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.grpDireccion = new System.Windows.Forms.GroupBox();
            this.txtLetraIdenti2 = new System.Windows.Forms.TextBox();
            this.lblGuion = new System.Windows.Forms.Label();
            this.txtPuntoCardinal2 = new System.Windows.Forms.TextBox();
            this.txtNumeroCuadra2 = new System.Windows.Forms.TextBox();
            this.txtNumeroCuadra = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtPuntoCardinal = new System.Windows.Forms.TextBox();
            this.txtLetraIdentifi = new System.Windows.Forms.TextBox();
            this.txtNumeroIdenti = new System.Windows.Forms.TextBox();
            this.cmbIdentiVia = new System.Windows.Forms.ComboBox();
            this.dtParto = new System.Windows.Forms.DateTimePicker();
            this.dtRegla = new System.Windows.Forms.DateTimePicker();
            this.txtPatologia = new System.Windows.Forms.TextBox();
            this.txtEdadAmenorrea = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblPatologia = new System.Windows.Forms.Label();
            this.lblEdadAmenorrea = new System.Windows.Forms.Label();
            this.lblFechaParto = new System.Windows.Forms.Label();
            this.lblFechaRegla = new System.Windows.Forms.Label();
            this.lblHabitos = new System.Windows.Forms.Label();
            this.lblUsaMedicamentos = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblDocBuscar = new System.Windows.Forms.Label();
            this.txtDocBuscar = new System.Windows.Forms.TextBox();
            this.pctreHospital = new System.Windows.Forms.PictureBox();
            this.tlMadre = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorMadre = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDatosAgrupados.SuspendLayout();
            this.grpMedicamentos.SuspendLayout();
            this.grpHabitos.SuspendLayout();
            this.grpDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctreHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMadre)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.bttnSalir.Location = new System.Drawing.Point(851, 591);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(122, 27);
            this.bttnSalir.TabIndex = 5;
            this.bttnSalir.Text = "Salir";
            this.tlMadre.SetToolTip(this.bttnSalir, "Pulse para salir");
            this.bttnSalir.UseVisualStyleBackColor = false;
       
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnEliminar.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.bttnEliminar.Location = new System.Drawing.Point(697, 591);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(122, 27);
            this.bttnEliminar.TabIndex = 4;
            this.bttnEliminar.Text = "Eliminar";
            this.tlMadre.SetToolTip(this.bttnEliminar, "Pulse para eliminar los datos");
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnActualizar.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.bttnActualizar.Location = new System.Drawing.Point(851, 532);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(122, 27);
            this.bttnActualizar.TabIndex = 3;
            this.bttnActualizar.Text = "Actualizar";
            this.tlMadre.SetToolTip(this.bttnActualizar, "Pulse para buscar el número ");
            this.bttnActualizar.UseVisualStyleBackColor = false;
            this.bttnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnRegistrar.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.bttnRegistrar.Location = new System.Drawing.Point(697, 532);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(122, 27);
            this.bttnRegistrar.TabIndex = 2;
            this.bttnRegistrar.Text = "Registrar";
            this.tlMadre.SetToolTip(this.bttnRegistrar, "Pulse para registrar los datos ingresados");
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDatosAgrupados
            // 
            this.grpDatosAgrupados.Controls.Add(this.grpMedicamentos);
            this.grpDatosAgrupados.Controls.Add(this.grpHabitos);
            this.grpDatosAgrupados.Controls.Add(this.cmbTipoDocumento);
            this.grpDatosAgrupados.Controls.Add(this.grpDireccion);
            this.grpDatosAgrupados.Controls.Add(this.dtParto);
            this.grpDatosAgrupados.Controls.Add(this.dtRegla);
            this.grpDatosAgrupados.Controls.Add(this.txtPatologia);
            this.grpDatosAgrupados.Controls.Add(this.txtEdadAmenorrea);
            this.grpDatosAgrupados.Controls.Add(this.txtIMC);
            this.grpDatosAgrupados.Controls.Add(this.txtTalla);
            this.grpDatosAgrupados.Controls.Add(this.txtPeso);
            this.grpDatosAgrupados.Controls.Add(this.txtTelefono);
            this.grpDatosAgrupados.Controls.Add(this.txtCiudad);
            this.grpDatosAgrupados.Controls.Add(this.txtNumeroDocumento);
            this.grpDatosAgrupados.Controls.Add(this.lblPatologia);
            this.grpDatosAgrupados.Controls.Add(this.lblEdadAmenorrea);
            this.grpDatosAgrupados.Controls.Add(this.lblFechaParto);
            this.grpDatosAgrupados.Controls.Add(this.lblFechaRegla);
            this.grpDatosAgrupados.Controls.Add(this.lblHabitos);
            this.grpDatosAgrupados.Controls.Add(this.lblUsaMedicamentos);
            this.grpDatosAgrupados.Controls.Add(this.lblIMC);
            this.grpDatosAgrupados.Controls.Add(this.lblTalla);
            this.grpDatosAgrupados.Controls.Add(this.lblPeso);
            this.grpDatosAgrupados.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosAgrupados.Controls.Add(this.dtFechaNacimiento);
            this.grpDatosAgrupados.Controls.Add(this.lblTelefono);
            this.grpDatosAgrupados.Controls.Add(this.lblCiudad);
            this.grpDatosAgrupados.Controls.Add(this.lblDireccion);
            this.grpDatosAgrupados.Controls.Add(this.lblNumeroDocumento);
            this.grpDatosAgrupados.Controls.Add(this.lblTipoDocumento);
            this.grpDatosAgrupados.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosAgrupados.Location = new System.Drawing.Point(3, 136);
            this.grpDatosAgrupados.Name = "grpDatosAgrupados";
            this.grpDatosAgrupados.Size = new System.Drawing.Size(991, 390);
            this.grpDatosAgrupados.TabIndex = 0;
            this.grpDatosAgrupados.TabStop = false;
            this.tlMadre.SetToolTip(this.grpDatosAgrupados, "Cuadro de datos");
            // 
            // grpMedicamentos
            // 
            this.grpMedicamentos.Controls.Add(this.rdSi);
            this.grpMedicamentos.Controls.Add(this.rdNo);
            this.grpMedicamentos.Location = new System.Drawing.Point(706, 69);
            this.grpMedicamentos.Name = "grpMedicamentos";
            this.grpMedicamentos.Size = new System.Drawing.Size(104, 39);
            this.grpMedicamentos.TabIndex = 41;
            this.grpMedicamentos.TabStop = false;
            this.grpMedicamentos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdSi
            // 
            this.rdSi.AutoSize = true;
            this.rdSi.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.rdSi.Location = new System.Drawing.Point(6, 13);
            this.rdSi.Name = "rdSi";
            this.rdSi.Size = new System.Drawing.Size(36, 22);
            this.rdSi.TabIndex = 10;
            this.rdSi.TabStop = true;
            this.rdSi.Text = "Si";
            this.tlMadre.SetToolTip(this.rdSi, "Presione para seleccionar si");
            this.rdSi.UseVisualStyleBackColor = true;
            // 
            // rdNo
            // 
            this.rdNo.AutoSize = true;
            this.rdNo.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.rdNo.Location = new System.Drawing.Point(59, 12);
            this.rdNo.Name = "rdNo";
            this.rdNo.Size = new System.Drawing.Size(45, 22);
            this.rdNo.TabIndex = 11;
            this.rdNo.TabStop = true;
            this.rdNo.Text = "No";
            this.tlMadre.SetToolTip(this.rdNo, "Presione para seleccionar no");
            this.rdNo.UseVisualStyleBackColor = true;
            // 
            // grpHabitos
            // 
            this.grpHabitos.Controls.Add(this.rdSi2);
            this.grpHabitos.Controls.Add(this.rdNo2);
            this.grpHabitos.Location = new System.Drawing.Point(706, 114);
            this.grpHabitos.Name = "grpHabitos";
            this.grpHabitos.Size = new System.Drawing.Size(104, 41);
            this.grpHabitos.TabIndex = 0;
            this.grpHabitos.TabStop = false;
            // 
            // rdSi2
            // 
            this.rdSi2.AutoSize = true;
            this.rdSi2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.rdSi2.Location = new System.Drawing.Point(6, 14);
            this.rdSi2.Name = "rdSi2";
            this.rdSi2.Size = new System.Drawing.Size(36, 22);
            this.rdSi2.TabIndex = 12;
            this.rdSi2.TabStop = true;
            this.rdSi2.Text = "Si";
            this.tlMadre.SetToolTip(this.rdSi2, "Presione para seleccionar si");
            this.rdSi2.UseVisualStyleBackColor = true;
            // 
            // rdNo2
            // 
            this.rdNo2.AutoSize = true;
            this.rdNo2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.rdNo2.Location = new System.Drawing.Point(59, 14);
            this.rdNo2.Name = "rdNo2";
            this.rdNo2.Size = new System.Drawing.Size(45, 22);
            this.rdNo2.TabIndex = 13;
            this.rdNo2.TabStop = true;
            this.rdNo2.Text = "No";
            this.tlMadre.SetToolTip(this.rdNo2, "Presione para seleccionar no");
            this.rdNo2.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "TI",
            "CE",
            "NIP",
            "NIT",
            "PAP"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(144, 34);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(121, 25);
            this.cmbTipoDocumento.TabIndex = 1;
            this.tlMadre.SetToolTip(this.cmbTipoDocumento, "Seleccione su tipo de documento de identidad");
            // 
            // grpDireccion
            // 
            this.grpDireccion.Controls.Add(this.txtLetraIdenti2);
            this.grpDireccion.Controls.Add(this.lblGuion);
            this.grpDireccion.Controls.Add(this.txtPuntoCardinal2);
            this.grpDireccion.Controls.Add(this.txtNumeroCuadra2);
            this.grpDireccion.Controls.Add(this.txtNumeroCuadra);
            this.grpDireccion.Controls.Add(this.lblNumero);
            this.grpDireccion.Controls.Add(this.txtPuntoCardinal);
            this.grpDireccion.Controls.Add(this.txtLetraIdentifi);
            this.grpDireccion.Controls.Add(this.txtNumeroIdenti);
            this.grpDireccion.Controls.Add(this.cmbIdentiVia);
            this.grpDireccion.Location = new System.Drawing.Point(144, 122);
            this.grpDireccion.Name = "grpDireccion";
            this.grpDireccion.Size = new System.Drawing.Size(408, 48);
            this.grpDireccion.TabIndex = 3;
            this.grpDireccion.TabStop = false;
            this.tlMadre.SetToolTip(this.grpDireccion, "Ingrese su dirección de residencia");
            // 
            // txtLetraIdenti2
            // 
            this.txtLetraIdenti2.Location = new System.Drawing.Point(265, 16);
            this.txtLetraIdenti2.Name = "txtLetraIdenti2";
            this.txtLetraIdenti2.Size = new System.Drawing.Size(30, 24);
            this.txtLetraIdenti2.TabIndex = 6;
            this.tlMadre.SetToolTip(this.txtLetraIdenti2, "Ingrese letra de identificación de la vía");
            // 
            // lblGuion
            // 
            this.lblGuion.AutoSize = true;
            this.lblGuion.Location = new System.Drawing.Point(301, 18);
            this.lblGuion.Name = "lblGuion";
            this.lblGuion.Size = new System.Drawing.Size(13, 17);
            this.lblGuion.TabIndex = 7;
            this.lblGuion.Text = "-";
            // 
            // txtPuntoCardinal2
            // 
            this.txtPuntoCardinal2.Location = new System.Drawing.Point(364, 15);
            this.txtPuntoCardinal2.Name = "txtPuntoCardinal2";
            this.txtPuntoCardinal2.Size = new System.Drawing.Size(38, 24);
            this.txtPuntoCardinal2.TabIndex = 9;
            this.tlMadre.SetToolTip(this.txtPuntoCardinal2, "Ingrese punto cardinal");
            // 
            // txtNumeroCuadra2
            // 
            this.txtNumeroCuadra2.Location = new System.Drawing.Point(320, 16);
            this.txtNumeroCuadra2.Name = "txtNumeroCuadra2";
            this.txtNumeroCuadra2.Size = new System.Drawing.Size(38, 24);
            this.txtNumeroCuadra2.TabIndex = 8;
            this.tlMadre.SetToolTip(this.txtNumeroCuadra2, "Ingrese número de identificación de la cuadra");
            // 
            // txtNumeroCuadra
            // 
            this.txtNumeroCuadra.Location = new System.Drawing.Point(221, 16);
            this.txtNumeroCuadra.Name = "txtNumeroCuadra";
            this.txtNumeroCuadra.Size = new System.Drawing.Size(38, 24);
            this.txtNumeroCuadra.TabIndex = 5;
            this.tlMadre.SetToolTip(this.txtNumeroCuadra, "Ingrese número de identificación de la cuadra");
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(201, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(16, 17);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "#";
            // 
            // txtPuntoCardinal
            // 
            this.txtPuntoCardinal.Location = new System.Drawing.Point(157, 15);
            this.txtPuntoCardinal.Name = "txtPuntoCardinal";
            this.txtPuntoCardinal.Size = new System.Drawing.Size(38, 24);
            this.txtPuntoCardinal.TabIndex = 3;
            this.tlMadre.SetToolTip(this.txtPuntoCardinal, "Ingrese punto cardinal");
            // 
            // txtLetraIdentifi
            // 
            this.txtLetraIdentifi.Location = new System.Drawing.Point(121, 14);
            this.txtLetraIdentifi.Name = "txtLetraIdentifi";
            this.txtLetraIdentifi.Size = new System.Drawing.Size(30, 24);
            this.txtLetraIdentifi.TabIndex = 2;
            this.tlMadre.SetToolTip(this.txtLetraIdentifi, "Ingrese letra de identificación de la vía");
            // 
            // txtNumeroIdenti
            // 
            this.txtNumeroIdenti.Location = new System.Drawing.Point(75, 14);
            this.txtNumeroIdenti.Name = "txtNumeroIdenti";
            this.txtNumeroIdenti.Size = new System.Drawing.Size(40, 24);
            this.txtNumeroIdenti.TabIndex = 1;
            this.tlMadre.SetToolTip(this.txtNumeroIdenti, "Ingrese número de identificación vía");
            // 
            // cmbIdentiVia
            // 
            this.cmbIdentiVia.FormattingEnabled = true;
            this.cmbIdentiVia.Items.AddRange(new object[] {
            "Calle",
            "Cra.",
            "Diag.",
            "Trans.",
            "Av."});
            this.cmbIdentiVia.Location = new System.Drawing.Point(6, 14);
            this.cmbIdentiVia.Name = "cmbIdentiVia";
            this.cmbIdentiVia.Size = new System.Drawing.Size(63, 25);
            this.cmbIdentiVia.TabIndex = 0;
            this.tlMadre.SetToolTip(this.cmbIdentiVia, "Seleccione el tipo de identificación de la vía");
            // 
            // dtParto
            // 
            this.dtParto.Location = new System.Drawing.Point(706, 219);
            this.dtParto.Name = "dtParto";
            this.dtParto.Size = new System.Drawing.Size(264, 24);
            this.dtParto.TabIndex = 15;
            this.tlMadre.SetToolTip(this.dtParto, "Seleccione la fecha del día de su parto");
            this.dtParto.ValueChanged += new System.EventHandler(this.dtParto_ValueChanged);
            // 
            // dtRegla
            // 
            this.dtRegla.Location = new System.Drawing.Point(706, 173);
            this.dtRegla.Name = "dtRegla";
            this.dtRegla.Size = new System.Drawing.Size(264, 24);
            this.dtRegla.TabIndex = 14;
            this.tlMadre.SetToolTip(this.dtRegla, "Seleccione la fecha de la última vez que tuvo su regla");
            this.dtRegla.ValueChanged += new System.EventHandler(this.dtRegla_ValueChanged);
            // 
            // txtPatologia
            // 
            this.txtPatologia.Location = new System.Drawing.Point(709, 306);
            this.txtPatologia.Name = "txtPatologia";
            this.txtPatologia.Size = new System.Drawing.Size(261, 24);
            this.txtPatologia.TabIndex = 17;
            this.tlMadre.SetToolTip(this.txtPatologia, "Ingrese la(s) patología(s) que tuvo durante el embarazo");
            // 
            // txtEdadAmenorrea
            // 
            this.txtEdadAmenorrea.Location = new System.Drawing.Point(706, 262);
            this.txtEdadAmenorrea.Name = "txtEdadAmenorrea";
            this.txtEdadAmenorrea.Size = new System.Drawing.Size(60, 24);
            this.txtEdadAmenorrea.TabIndex = 16;
            this.tlMadre.SetToolTip(this.txtEdadAmenorrea, "Ingrese la edad del día que tuvo ausencia de la menstruación");
            this.txtEdadAmenorrea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdadAmenorrea_KeyPress_4);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(706, 39);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(264, 24);
            this.txtIMC.TabIndex = 9;
            this.tlMadre.SetToolTip(this.txtIMC, "Ingrese su índice de masa corporal");
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(144, 354);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(259, 24);
            this.txtTalla.TabIndex = 8;
            this.tlMadre.SetToolTip(this.txtTalla, "Ingrese su talla de busto");
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(144, 306);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(259, 24);
            this.txtPeso.TabIndex = 7;
            this.tlMadre.SetToolTip(this.txtPeso, "Ingrese su peso en kilogramos (kg)");
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress_3);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(144, 222);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 24);
            this.txtTelefono.TabIndex = 5;
            this.tlMadre.SetToolTip(this.txtTelefono, "Ingrese su número de teléfono ");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress_2);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(144, 176);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(259, 24);
            this.txtCiudad.TabIndex = 4;
            this.tlMadre.SetToolTip(this.txtCiudad, "Ingrese su ciudad de residencia");
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(144, 84);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(259, 24);
            this.txtNumeroDocumento.TabIndex = 2;
            this.tlMadre.SetToolTip(this.txtNumeroDocumento, "Ingrese su número de documento ");
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDocumento_KeyPress_1);
            // 
            // lblPatologia
            // 
            this.lblPatologia.AutoSize = true;
            this.lblPatologia.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblPatologia.Location = new System.Drawing.Point(558, 311);
            this.lblPatologia.Name = "lblPatologia";
            this.lblPatologia.Size = new System.Drawing.Size(146, 16);
            this.lblPatologia.TabIndex = 0;
            this.lblPatologia.Text = "Patología en embarazo";
            this.tlMadre.SetToolTip(this.lblPatologia, "Patología en embarazo");
            // 
            // lblEdadAmenorrea
            // 
            this.lblEdadAmenorrea.AutoSize = true;
            this.lblEdadAmenorrea.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblEdadAmenorrea.Location = new System.Drawing.Point(558, 267);
            this.lblEdadAmenorrea.Name = "lblEdadAmenorrea";
            this.lblEdadAmenorrea.Size = new System.Drawing.Size(108, 16);
            this.lblEdadAmenorrea.TabIndex = 0;
            this.lblEdadAmenorrea.Text = "Edad amenorrea";
            this.tlMadre.SetToolTip(this.lblEdadAmenorrea, "Edad amenorrea");
            // 
            // lblFechaParto
            // 
            this.lblFechaParto.AutoSize = true;
            this.lblFechaParto.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblFechaParto.Location = new System.Drawing.Point(558, 222);
            this.lblFechaParto.Name = "lblFechaParto";
            this.lblFechaParto.Size = new System.Drawing.Size(101, 16);
            this.lblFechaParto.TabIndex = 0;
            this.lblFechaParto.Text = "Fecha del parto";
            this.tlMadre.SetToolTip(this.lblFechaParto, "Fecha del parto");
            // 
            // lblFechaRegla
            // 
            this.lblFechaRegla.AutoSize = true;
            this.lblFechaRegla.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblFechaRegla.Location = new System.Drawing.Point(558, 176);
            this.lblFechaRegla.Name = "lblFechaRegla";
            this.lblFechaRegla.Size = new System.Drawing.Size(115, 16);
            this.lblFechaRegla.TabIndex = 0;
            this.lblFechaRegla.Text = "Fecha última regla";
            this.tlMadre.SetToolTip(this.lblFechaRegla, "Fecha última regla");
            // 
            // lblHabitos
            // 
            this.lblHabitos.AutoSize = true;
            this.lblHabitos.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblHabitos.Location = new System.Drawing.Point(558, 133);
            this.lblHabitos.Name = "lblHabitos";
            this.lblHabitos.Size = new System.Drawing.Size(136, 16);
            this.lblHabitos.TabIndex = 0;
            this.lblHabitos.Text = "¿Tiene hábitos tóxicos?";
            this.tlMadre.SetToolTip(this.lblHabitos, "Seleccione si tiene hábitos tóxicos");
            // 
            // lblUsaMedicamentos
            // 
            this.lblUsaMedicamentos.AutoSize = true;
            this.lblUsaMedicamentos.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblUsaMedicamentos.Location = new System.Drawing.Point(558, 89);
            this.lblUsaMedicamentos.Name = "lblUsaMedicamentos";
            this.lblUsaMedicamentos.Size = new System.Drawing.Size(126, 16);
            this.lblUsaMedicamentos.TabIndex = 0;
            this.lblUsaMedicamentos.Text = "¿Usa medicamentos?";
            this.tlMadre.SetToolTip(this.lblUsaMedicamentos, "Seleccione si usa o no medicamentos");
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblIMC.Location = new System.Drawing.Point(616, 39);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(30, 16);
            this.lblIMC.TabIndex = 0;
            this.lblIMC.Text = "IMC";
            this.tlMadre.SetToolTip(this.lblIMC, "IMC");
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblTalla.Location = new System.Drawing.Point(16, 355);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(35, 16);
            this.lblTalla.TabIndex = 0;
            this.lblTalla.Text = "Talla";
            this.tlMadre.SetToolTip(this.lblTalla, "Talla");
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblPeso.Location = new System.Drawing.Point(16, 307);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 16);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            this.tlMadre.SetToolTip(this.lblPeso, "Peso");
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblFechaNacimiento.Location = new System.Drawing.Point(16, 267);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(127, 16);
            this.lblFechaNacimiento.TabIndex = 0;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            this.tlMadre.SetToolTip(this.lblFechaNacimiento, "Fecha de nacimiento");
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CalendarFont = new System.Drawing.Font("Arial", 9F);
            this.dtFechaNacimiento.Location = new System.Drawing.Point(144, 266);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(259, 24);
            this.dtFechaNacimiento.TabIndex = 6;
            this.tlMadre.SetToolTip(this.dtFechaNacimiento, "Seleccione su fecha de nacimiento");
            this.dtFechaNacimiento.ValueChanged += new System.EventHandler(this.dataTimePicker1_ValueChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblTelefono.Location = new System.Drawing.Point(16, 227);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 16);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Teléfono";
            this.tlMadre.SetToolTip(this.lblTelefono, "Teléfono");
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblCiudad.Location = new System.Drawing.Point(16, 181);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(49, 16);
            this.lblCiudad.TabIndex = 0;
            this.lblCiudad.Text = "Ciudad";
            this.tlMadre.SetToolTip(this.lblCiudad, "Ciudad");
            this.lblCiudad.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblDireccion.Location = new System.Drawing.Point(16, 133);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 16);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            this.tlMadre.SetToolTip(this.lblDireccion, "Dirección");
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblNumeroDocumento.Location = new System.Drawing.Point(16, 87);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(122, 16);
            this.lblNumeroDocumento.TabIndex = 0;
            this.lblNumeroDocumento.Text = "Número documento";
            this.tlMadre.SetToolTip(this.lblNumeroDocumento, "Número documento");
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblTipoDocumento.Location = new System.Drawing.Point(16, 39);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(119, 16);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "Tipo de documento";
            this.tlMadre.SetToolTip(this.lblTipoDocumento, "Tipo de documento");
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSalmon;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.button5.Location = new System.Drawing.Point(12, 613);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 27);
            this.button5.TabIndex = 6;
            this.button5.Text = "Regresar";
            this.tlMadre.SetToolTip(this.button5, "Pulse para regresar");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblDocBuscar
            // 
            this.lblDocBuscar.AutoSize = true;
            this.lblDocBuscar.Font = new System.Drawing.Font("Berlin Sans FB", 10F);
            this.lblDocBuscar.Location = new System.Drawing.Point(159, 564);
            this.lblDocBuscar.Name = "lblDocBuscar";
            this.lblDocBuscar.Size = new System.Drawing.Size(247, 16);
            this.lblDocBuscar.TabIndex = 1;
            this.lblDocBuscar.Text = "Número de documento que desea buscar";
            this.tlMadre.SetToolTip(this.lblDocBuscar, "Número de documento que desea buscar");
            // 
            // txtDocBuscar
            // 
            this.txtDocBuscar.Location = new System.Drawing.Point(421, 562);
            this.txtDocBuscar.Name = "txtDocBuscar";
            this.txtDocBuscar.Size = new System.Drawing.Size(255, 20);
            this.txtDocBuscar.TabIndex = 1;
            this.tlMadre.SetToolTip(this.txtDocBuscar, "Ingrese número de identificación de la madre");
            this.txtDocBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocBuscar_KeyPress_5);
            // 
            // pctreHospital
            // 
            this.pctreHospital.BackColor = System.Drawing.Color.White;
            this.pctreHospital.Image = global::Lechematerna2.Properties.Resources.descarga;
            this.pctreHospital.Location = new System.Drawing.Point(389, 8);
            this.pctreHospital.Margin = new System.Windows.Forms.Padding(2);
            this.pctreHospital.Name = "pctreHospital";
            this.pctreHospital.Size = new System.Drawing.Size(265, 113);
            this.pctreHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctreHospital.TabIndex = 40;
            this.pctreHospital.TabStop = false;
            this.tlMadre.SetToolTip(this.pctreHospital, "Logo Hospital General de Medellín");
            this.pctreHospital.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ErrorMadre
            // 
            this.ErrorMadre.ContainerControl = this;
            // 
            // FrmDatosMadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 646);
            this.Controls.Add(this.pctreHospital);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtDocBuscar);
            this.Controls.Add(this.lblDocBuscar);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.grpDatosAgrupados);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnEliminar);
            this.Name = "FrmDatosMadre";
            this.Text = "DatosMadre";
            this.grpDatosAgrupados.ResumeLayout(false);
            this.grpDatosAgrupados.PerformLayout();
            this.grpMedicamentos.ResumeLayout(false);
            this.grpMedicamentos.PerformLayout();
            this.grpHabitos.ResumeLayout(false);
            this.grpHabitos.PerformLayout();
            this.grpDireccion.ResumeLayout(false);
            this.grpDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctreHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorMadre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.GroupBox grpDatosAgrupados;
        private System.Windows.Forms.RadioButton rdNo2;
        private System.Windows.Forms.RadioButton rdSi2;
        private System.Windows.Forms.RadioButton rdNo;
        private System.Windows.Forms.RadioButton rdSi;
        private System.Windows.Forms.DateTimePicker dtParto;
        private System.Windows.Forms.DateTimePicker dtRegla;
        private System.Windows.Forms.TextBox txtPatologia;
        private System.Windows.Forms.TextBox txtEdadAmenorrea;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblPatologia;
        private System.Windows.Forms.Label lblEdadAmenorrea;
        private System.Windows.Forms.Label lblFechaParto;
        private System.Windows.Forms.Label lblFechaRegla;
        private System.Windows.Forms.Label lblHabitos;
        private System.Windows.Forms.Label lblUsaMedicamentos;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblDocBuscar;
        private System.Windows.Forms.TextBox txtDocBuscar;
        private System.Windows.Forms.PictureBox pctreHospital;
        private System.Windows.Forms.ComboBox cmbIdentiVia;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox grpDireccion;
        private System.Windows.Forms.Label lblGuion;
        private System.Windows.Forms.TextBox txtPuntoCardinal2;
        private System.Windows.Forms.TextBox txtNumeroCuadra2;
        private System.Windows.Forms.TextBox txtNumeroCuadra;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtPuntoCardinal;
        private System.Windows.Forms.TextBox txtLetraIdentifi;
        private System.Windows.Forms.TextBox txtNumeroIdenti;
        private System.Windows.Forms.TextBox txtLetraIdenti2;
        private System.Windows.Forms.ToolTip tlMadre;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.ErrorProvider ErrorMadre;
        private System.Windows.Forms.GroupBox grpMedicamentos;
        private System.Windows.Forms.GroupBox grpHabitos;
        private EventHandler bttnEliminar_Click;
        private EventHandler button2_Click;
        private EventHandler groupBox1_Enter;
        private EventHandler dtParto_ValueChanged;
        private EventHandler dtRegla_ValueChanged;
        private KeyPressEventHandler txtEdadAmenorrea_KeyPress_4;
        private KeyPressEventHandler txtPeso_KeyPress_3;
        private readonly EventHandler txtNumeroDocumento_TextChanged;

        public KeyPressEventHandler txtTelefono_KeyPress_2 { get; private set; }
        public KeyPressEventHandler txtNumeroDocumento_KeyPress_1 { get; private set; }
    }
}