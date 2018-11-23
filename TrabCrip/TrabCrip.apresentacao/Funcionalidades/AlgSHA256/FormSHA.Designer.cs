namespace TrabCrip.apresentacao.Funcionalidades.AlgSHA256
{
    partial class FormSHA
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
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.lbEncrip = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(28, 59);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(196, 70);
            this.btnEncriptar.TabIndex = 7;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // lbEncrip
            // 
            this.lbEncrip.FormattingEnabled = true;
            this.lbEncrip.Location = new System.Drawing.Point(4, 164);
            this.lbEncrip.Name = "lbEncrip";
            this.lbEncrip.Size = new System.Drawing.Size(252, 95);
            this.lbEncrip.TabIndex = 6;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(4, 8);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(252, 20);
            this.txtTexto.TabIndex = 5;
            // 
            // FormSHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 270);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lbEncrip);
            this.Controls.Add(this.txtTexto);
            this.Name = "FormSHA";
            this.Text = "FormSHA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.ListBox lbEncrip;
        private System.Windows.Forms.TextBox txtTexto;
    }
}