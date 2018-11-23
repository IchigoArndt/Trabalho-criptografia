namespace TrabCrip.apresentacao.Funcionalidades.AlgRSHA
{
    partial class FormRSHA
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
            this.btnDecriptar = new System.Windows.Forms.Button();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.lbDecript = new System.Windows.Forms.ListBox();
            this.lbEncrip = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecriptar
            // 
            this.btnDecriptar.Location = new System.Drawing.Point(77, 173);
            this.btnDecriptar.Name = "btnDecriptar";
            this.btnDecriptar.Size = new System.Drawing.Size(117, 23);
            this.btnDecriptar.TabIndex = 10;
            this.btnDecriptar.Text = "Decriptar";
            this.btnDecriptar.UseVisualStyleBackColor = true;
            this.btnDecriptar.Click += new System.EventHandler(this.btnDecriptar_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(77, 38);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(117, 23);
            this.btnEncriptar.TabIndex = 9;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // lbDecript
            // 
            this.lbDecript.FormattingEnabled = true;
            this.lbDecript.Location = new System.Drawing.Point(12, 214);
            this.lbDecript.Name = "lbDecript";
            this.lbDecript.Size = new System.Drawing.Size(256, 95);
            this.lbDecript.TabIndex = 8;
            // 
            // lbEncrip
            // 
            this.lbEncrip.FormattingEnabled = true;
            this.lbEncrip.Location = new System.Drawing.Point(12, 72);
            this.lbEncrip.Name = "lbEncrip";
            this.lbEncrip.Size = new System.Drawing.Size(256, 95);
            this.lbEncrip.TabIndex = 7;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(256, 20);
            this.txtTexto.TabIndex = 6;
            // 
            // FormRSHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 331);
            this.Controls.Add(this.btnDecriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lbDecript);
            this.Controls.Add(this.lbEncrip);
            this.Controls.Add(this.txtTexto);
            this.Name = "FormRSHA";
            this.Text = "FormRSHA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.ListBox lbDecript;
        private System.Windows.Forms.ListBox lbEncrip;
        private System.Windows.Forms.TextBox txtTexto;
    }
}