namespace Lechematerna2
{
    partial class FrmDatosDonacion
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
            this.bttnRegistrar = new System.Windows.Forms.Button();
            this.grpDatosAgrupados = new System.Windows.Forms.GroupBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtEtiquetado = new System.Windows.Forms.TextBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtCantidadLeche = new System.Windows.Forms.TextBox();
            this.lblEtiquetado = new System.Windows.Forms.Label();
            this.txtCodigoRecipiente = new System.Windows.Forms.TextBox();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtRecoleccion = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblCantidadLeche = new System.Windows.Forms.Label();
            this.lblCodigoRecipiente = new System.Windows.Forms.Label();
            this.lblFechaRecolección = new System.Windows.Forms.Label();
            this.bttnRegresar = new System.Windows.Forms.Button();
            this.pctrHospital = new System.Windows.Forms.PictureBox();
            this.tlDonacion = new System.Windows.Forms.ToolTip(this.components);
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpDatosAgrupados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHospital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.bttnSalir.Location = new System.Drawing.Point(408, 445);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(100, 47);
            this.bttnSalir.TabIndex = 3;
            this.bttnSalir.Text = "Salir";
            this.tlDonacion.SetToolTip(this.bttnSalir, "Pulse para salir");
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnRegistrar
            // 
            this.bttnRegistrar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnRegistrar.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.bttnRegistrar.Location = new System.Drawing.Point(142, 445);
            this.bttnRegistrar.Name = "bttnRegistrar";
            this.bttnRegistrar.Size = new System.Drawing.Size(100, 47);
            this.bttnRegistrar.TabIndex = 1;
            this.bttnRegistrar.Text = "Registrar";
            this.tlDonacion.SetToolTip(this.bttnRegistrar, "Pulse para registrar los datos");
            this.bttnRegistrar.UseVisualStyleBackColor = false;
            this.bttnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpDatosAgrupados
            // 
            this.grpDatosAgrupados.AutoSize = true;
            this.grpDatosAgrupados.Controls.Add(this.txtRegistro);
            this.grpDatosAgrupados.Controls.Add(this.txtEtiquetado);
            this.grpDatosAgrupados.Controls.Add(this.lblRegistro);
            this.grpDatosAgrupados.Controls.Add(this.txtCantidadLeche);
            this.grpDatosAgrupados.Controls.Add(this.lblEtiquetado);
            this.grpDatosAgrupados.Controls.Add(this.txtCodigoRecipiente);
            this.grpDatosAgrupados.Controls.Add(this.dtVencimiento);
            this.grpDatosAgrupados.Controls.Add(this.dtRecoleccion);
            this.grpDatosAgrupados.Controls.Add(this.lblVencimiento);
            this.grpDatosAgrupados.Controls.Add(this.lblCantidadLeche);
            this.grpDatosAgrupados.Controls.Add(this.lblCodigoRecipiente);
            this.grpDatosAgrupados.Controls.Add(this.lblFechaRecolección);
            this.grpDatosAgrupados.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosAgrupados.Location = new System.Drawing.Point(72, 122);
            this.grpDatosAgrupados.Name = "grpDatosAgrupados";
            this.grpDatosAgrupados.Size = new System.Drawing.Size(520, 317);
            this.grpDatosAgrupados.TabIndex = 0;
            this.grpDatosAgrupados.TabStop = false;
            this.grpDatosAgrupados.Text = "Datos";
            this.tlDonacion.SetToolTip(this.grpDatosAgrupados, "Cuadro de datos ");
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(230, 127);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(255, 21);
            this.txtRegistro.TabIndex = 3;
            this.tlDonacion.SetToolTip(this.txtRegistro, "Ingrese el registro del recipiente");
            this.txtRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistro_KeyPress_1);
            // 
            // txtEtiquetado
            // 
            this.txtEtiquetado.Location = new System.Drawing.Point(230, 29);
            this.txtEtiquetado.Name = "txtEtiquetado";
            this.txtEtiquetado.Size = new System.Drawing.Size(255, 21);
            this.txtEtiquetado.TabIndex = 1;
            this.tlDonacion.SetToolTip(this.txtEtiquetado, "Ingrese el etiquetado del recipiente");
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblRegistro.Location = new System.Drawing.Point(29, 128);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(57, 17);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            this.tlDonacion.SetToolTip(this.lblRegistro, "Registro");
            this.lblRegistro.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCantidadLeche
            // 
            this.txtCantidadLeche.Location = new System.Drawing.Point(230, 227);
            this.txtCantidadLeche.Name = "txtCantidadLeche";
            this.txtCantidadLeche.Size = new System.Drawing.Size(255, 21);
            this.txtCantidadLeche.TabIndex = 5;
            this.tlDonacion.SetToolTip(this.txtCantidadLeche, "Ingrese la cantidad de leche en mililitros");
            // 
            // lblEtiquetado
            // 
            this.lblEtiquetado.AutoSize = true;
            this.lblEtiquetado.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblEtiquetado.Location = new System.Drawing.Point(29, 30);
            this.lblEtiquetado.Name = "lblEtiquetado";
            this.lblEtiquetado.Size = new System.Drawing.Size(76, 17);
            this.lblEtiquetado.TabIndex = 0;
            this.lblEtiquetado.Text = "Etiquetado";
            this.tlDonacion.SetToolTip(this.lblEtiquetado, "Etiquetado");
            this.lblEtiquetado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoRecipiente
            // 
            this.txtCodigoRecipiente.Location = new System.Drawing.Point(230, 176);
            this.txtCodigoRecipiente.Name = "txtCodigoRecipiente";
            this.txtCodigoRecipiente.Size = new System.Drawing.Size(255, 21);
            this.txtCodigoRecipiente.TabIndex = 4;
            this.tlDonacion.SetToolTip(this.txtCodigoRecipiente, "Ingrese la identificación del recipiente");
            this.txtCodigoRecipiente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoRecipiente_KeyPress_2);
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Location = new System.Drawing.Point(230, 276);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(255, 21);
            this.dtVencimiento.TabIndex = 6;
            this.tlDonacion.SetToolTip(this.dtVencimiento, "Ingrese fecha de vencimiento de la leche donada");
            this.dtVencimiento.ValueChanged += new System.EventHandler(this.dtVencimiento_ValueChanged);
            // 
            // dtRecoleccion
            // 
            this.dtRecoleccion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRecoleccion.Location = new System.Drawing.Point(230, 78);
            this.dtRecoleccion.Name = "dtRecoleccion";
            this.dtRecoleccion.Size = new System.Drawing.Size(255, 21);
            this.dtRecoleccion.TabIndex = 2;
            this.tlDonacion.SetToolTip(this.dtRecoleccion, "Ingrese la fecha de recolección del recipiente");
            this.dtRecoleccion.ValueChanged += new System.EventHandler(this.dtFechaRecoleccion_ValueChanged);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblVencimiento.Location = new System.Drawing.Point(29, 280);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(142, 17);
            this.lblVencimiento.TabIndex = 0;
            this.lblVencimiento.Text = "Fecha de vencimiento";
            this.tlDonacion.SetToolTip(this.lblVencimiento, "Fecha de vencimiento");
            // 
            // lblCantidadLeche
            // 
            this.lblCantidadLeche.AutoSize = true;
            this.lblCantidadLeche.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblCantidadLeche.Location = new System.Drawing.Point(29, 231);
            this.lblCantidadLeche.Name = "lblCantidadLeche";
            this.lblCantidadLeche.Size = new System.Drawing.Size(201, 17);
            this.lblCantidadLeche.TabIndex = 0;
            this.lblCantidadLeche.Text = "Cantidad de leche donada (ml)";
            this.tlDonacion.SetToolTip(this.lblCantidadLeche, "Cantidad de leche donada (ml)");
            // 
            // lblCodigoRecipiente
            // 
            this.lblCodigoRecipiente.AutoSize = true;
            this.lblCodigoRecipiente.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblCodigoRecipiente.Location = new System.Drawing.Point(29, 180);
            this.lblCodigoRecipiente.Name = "lblCodigoRecipiente";
            this.lblCodigoRecipiente.Size = new System.Drawing.Size(106, 17);
            this.lblCodigoRecipiente.TabIndex = 0;
            this.lblCodigoRecipiente.Text = "ID del recipiente";
            this.tlDonacion.SetToolTip(this.lblCodigoRecipiente, "ID del recipiente");
            // 
            // lblFechaRecolección
            // 
            this.lblFechaRecolección.AutoSize = true;
            this.lblFechaRecolección.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.lblFechaRecolección.Location = new System.Drawing.Point(29, 82);
            this.lblFechaRecolección.Name = "lblFechaRecolección";
            this.lblFechaRecolección.Size = new System.Drawing.Size(135, 17);
            this.lblFechaRecolección.TabIndex = 0;
            this.lblFechaRecolección.Text = "Fecha de recolección";
            this.tlDonacion.SetToolTip(this.lblFechaRecolección, "Fecha de recolección");
            // 
            // bttnRegresar
            // 
            this.bttnRegresar.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnRegresar.Font = new System.Drawing.Font("Berlin Sans FB", 11F);
            this.bttnRegresar.Location = new System.Drawing.Point(277, 445);
            this.bttnRegresar.Name = "bttnRegresar";
            this.bttnRegresar.Size = new System.Drawing.Size(100, 47);
            this.bttnRegresar.TabIndex = 2;
            this.bttnRegresar.Text = "Regresar";
            this.tlDonacion.SetToolTip(this.bttnRegresar, "Pulse para regresar");
            this.bttnRegresar.UseVisualStyleBackColor = false;
            this.bttnRegresar.Click += new System.EventHandler(this.bttnRegresar_Click);
            // 
            // pctrHospital
            // 
            this.pctrHospital.BackColor = System.Drawing.Color.White;
            this.pctrHospital.Image = global::Lechematerna2.Properties.Resources.descarga;
            this.pctrHospital.Location = new System.Drawing.Point(60, 8);
            this.pctrHospital.Margin = new System.Windows.Forms.Padding(2);
            this.pctrHospital.Name = "pctrHospital";
            this.pctrHospital.Size = new System.Drawing.Size(243, 97);
            this.pctrHospital.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHospital.TabIndex = 9;
            this.pctrHospital.TabStop = false;
            this.tlDonacion.SetToolTip(this.pctrHospital, "Logo Hospital General de Medellín");
            // 
            // tlDonacion
            // 
            this.tlDonacion.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // FrmDatosDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 504);
            this.Controls.Add(this.bttnRegresar);
            this.Controls.Add(this.pctrHospital);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.bttnRegistrar);
            this.Controls.Add(this.grpDatosAgrupados);
            this.Name = "FrmDatosDonacion";
            this.Text = "Datos Donación";
            this.Load += new System.EventHandler(this.Datos_Donacion_Load);
            this.grpDatosAgrupados.ResumeLayout(false);
            this.grpDatosAgrupados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHospital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnRegistrar;
        private System.Windows.Forms.GroupBox grpDatosAgrupados;
        private System.Windows.Forms.TextBox txtCantidadLeche;
        private System.Windows.Forms.TextBox txtCodigoRecipiente;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.DateTimePicker dtRecoleccion;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblCantidadLeche;
        private System.Windows.Forms.Label lblCodigoRecipiente;
        private System.Windows.Forms.Label lblFechaRecolección;
        private System.Windows.Forms.PictureBox pctrHospital;
        private System.Windows.Forms.Button bttnRegresar;
        private System.Windows.Forms.Label lblEtiquetado;
        private System.Windows.Forms.TextBox txtEtiquetado;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.ToolTip tlDonacion;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}