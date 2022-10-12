
namespace Lechematerna2
{
    partial class FrmListaOpciones
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
            this.bttnDatosMadre = new System.Windows.Forms.Button();
            this.bttnDatosDonacion = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.bttnRegresar = new System.Windows.Forms.Button();
            this.tlOpciones = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // bttnDatosMadre
            // 
            this.bttnDatosMadre.BackColor = System.Drawing.Color.Snow;
            this.bttnDatosMadre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDatosMadre.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDatosMadre.Location = new System.Drawing.Point(35, 12);
            this.bttnDatosMadre.Name = "bttnDatosMadre";
            this.bttnDatosMadre.Size = new System.Drawing.Size(163, 71);
            this.bttnDatosMadre.TabIndex = 0;
            this.bttnDatosMadre.Text = "Datos Madre";
            this.tlOpciones.SetToolTip(this.bttnDatosMadre, "Pulsa para ingresar a datos de la madre");
            this.bttnDatosMadre.UseVisualStyleBackColor = false;
            this.bttnDatosMadre.Click += new System.EventHandler(this.bttnDatosMadre_Click);
            // 
            // bttnDatosDonacion
            // 
            this.bttnDatosDonacion.BackColor = System.Drawing.Color.Snow;
            this.bttnDatosDonacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnDatosDonacion.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDatosDonacion.Location = new System.Drawing.Point(35, 89);
            this.bttnDatosDonacion.Name = "bttnDatosDonacion";
            this.bttnDatosDonacion.Size = new System.Drawing.Size(163, 68);
            this.bttnDatosDonacion.TabIndex = 1;
            this.bttnDatosDonacion.Text = "Datos Donación";
            this.tlOpciones.SetToolTip(this.bttnDatosDonacion, "Pulsa para ingresar a datos de donación");
            this.bttnDatosDonacion.UseVisualStyleBackColor = false;
            this.bttnDatosDonacion.Click += new System.EventHandler(this.bttnDatosDonacion_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.Black;
            this.bttnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalir.ForeColor = System.Drawing.Color.White;
            this.bttnSalir.Location = new System.Drawing.Point(12, 163);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(97, 40);
            this.bttnSalir.TabIndex = 2;
            this.bttnSalir.Text = "SALIR";
            this.tlOpciones.SetToolTip(this.bttnSalir, "Pulsa para salir");
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSALIR_Click);
            // 
            // bttnRegresar
            // 
            this.bttnRegresar.BackColor = System.Drawing.Color.Black;
            this.bttnRegresar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRegresar.ForeColor = System.Drawing.Color.White;
            this.bttnRegresar.Location = new System.Drawing.Point(116, 163);
            this.bttnRegresar.Name = "bttnRegresar";
            this.bttnRegresar.Size = new System.Drawing.Size(97, 40);
            this.bttnRegresar.TabIndex = 3;
            this.bttnRegresar.Text = "REGRESAR";
            this.tlOpciones.SetToolTip(this.bttnRegresar, "Pulsa para regresar");
            this.bttnRegresar.UseVisualStyleBackColor = false;
            this.bttnRegresar.Click += new System.EventHandler(this.bttnRegresar_Click);
            // 
            // FrmListaOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(225, 219);
            this.Controls.Add(this.bttnRegresar);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.bttnDatosDonacion);
            this.Controls.Add(this.bttnDatosMadre);
            this.Name = "FrmListaOpciones";
            this.Text = "Lista Opciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnDatosMadre;
        private System.Windows.Forms.Button bttnDatosDonacion;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnRegresar;
        private System.Windows.Forms.ToolTip tlOpciones;
    }
}