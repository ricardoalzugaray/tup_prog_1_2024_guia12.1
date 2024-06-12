namespace Ejercicio1
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AgregarCompetidor = new System.Windows.Forms.Button();
            this.btn_CargarTiempo = new System.Windows.Forms.Button();
            this.btn_VerResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AgregarCompetidor
            // 
            this.btn_AgregarCompetidor.Location = new System.Drawing.Point(38, 31);
            this.btn_AgregarCompetidor.Name = "btn_AgregarCompetidor";
            this.btn_AgregarCompetidor.Size = new System.Drawing.Size(226, 55);
            this.btn_AgregarCompetidor.TabIndex = 0;
            this.btn_AgregarCompetidor.Text = "Agregar Competidor";
            this.btn_AgregarCompetidor.UseVisualStyleBackColor = true;
            this.btn_AgregarCompetidor.Click += new System.EventHandler(this.btn_AgregarCompetidor_Click);
            // 
            // btn_CargarTiempo
            // 
            this.btn_CargarTiempo.Location = new System.Drawing.Point(38, 109);
            this.btn_CargarTiempo.Name = "btn_CargarTiempo";
            this.btn_CargarTiempo.Size = new System.Drawing.Size(226, 60);
            this.btn_CargarTiempo.TabIndex = 1;
            this.btn_CargarTiempo.Text = "Cargar Tiempos de Competidores";
            this.btn_CargarTiempo.UseVisualStyleBackColor = true;
            this.btn_CargarTiempo.Click += new System.EventHandler(this.btn_CargarTiempo_Click);
            // 
            // btn_VerResultado
            // 
            this.btn_VerResultado.Location = new System.Drawing.Point(38, 193);
            this.btn_VerResultado.Name = "btn_VerResultado";
            this.btn_VerResultado.Size = new System.Drawing.Size(226, 55);
            this.btn_VerResultado.TabIndex = 2;
            this.btn_VerResultado.Text = "Ver Resultador";
            this.btn_VerResultado.UseVisualStyleBackColor = true;
            this.btn_VerResultado.Click += new System.EventHandler(this.btn_VerResultado_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 280);
            this.Controls.Add(this.btn_VerResultado);
            this.Controls.Add(this.btn_CargarTiempo);
            this.Controls.Add(this.btn_AgregarCompetidor);
            this.Name = "ventanaPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarCompetidor;
        private System.Windows.Forms.Button btn_CargarTiempo;
        private System.Windows.Forms.Button btn_VerResultado;
    }
}

