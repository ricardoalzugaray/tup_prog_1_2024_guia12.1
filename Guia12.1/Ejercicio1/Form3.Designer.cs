namespace Ejercicio1
{
    partial class ventanaCargarTiempo
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
            this.lbNumeroCompetidor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHH = new System.Windows.Forms.TextBox();
            this.tbMM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AgregarTiempo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumeroCompetidor
            // 
            this.lbNumeroCompetidor.AutoSize = true;
            this.lbNumeroCompetidor.Location = new System.Drawing.Point(22, 25);
            this.lbNumeroCompetidor.Name = "lbNumeroCompetidor";
            this.lbNumeroCompetidor.Size = new System.Drawing.Size(103, 13);
            this.lbNumeroCompetidor.TabIndex = 0;
            this.lbNumeroCompetidor.Text = "Numero Competidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiempo:";
            // 
            // tbHH
            // 
            this.tbHH.Location = new System.Drawing.Point(136, 52);
            this.tbHH.Name = "tbHH";
            this.tbHH.Size = new System.Drawing.Size(49, 20);
            this.tbHH.TabIndex = 2;
            // 
            // tbMM
            // 
            this.tbMM.Location = new System.Drawing.Point(207, 52);
            this.tbMM.Name = "tbMM";
            this.tbMM.Size = new System.Drawing.Size(47, 20);
            this.tbMM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "lbNumeroCompetidor";
            // 
            // btn_AgregarTiempo
            // 
            this.btn_AgregarTiempo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_AgregarTiempo.Location = new System.Drawing.Point(83, 87);
            this.btn_AgregarTiempo.Name = "btn_AgregarTiempo";
            this.btn_AgregarTiempo.Size = new System.Drawing.Size(102, 33);
            this.btn_AgregarTiempo.TabIndex = 6;
            this.btn_AgregarTiempo.Text = "Agregar";
            this.btn_AgregarTiempo.UseVisualStyleBackColor = true;
            // 
            // ventanaCargarTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 132);
            this.Controls.Add(this.btn_AgregarTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMM);
            this.Controls.Add(this.tbHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNumeroCompetidor);
            this.Name = "ventanaCargarTiempo";
            this.Text = "Carga de Tiempo del competidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumeroCompetidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHH;
        private System.Windows.Forms.TextBox tbMM;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_AgregarTiempo;
    }
}