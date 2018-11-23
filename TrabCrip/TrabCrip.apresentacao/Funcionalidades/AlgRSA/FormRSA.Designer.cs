namespace TrabCrip.apresentacao.Funcionalidades
{
    partial class FormRSA
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lbEncrip = new System.Windows.Forms.ListBox();
            this.lbDecript = new System.Windows.Forms.ListBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDecriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(256, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // lbEncrip
            // 
            this.lbEncrip.FormattingEnabled = true;
            this.lbEncrip.Location = new System.Drawing.Point(12, 72);
            this.lbEncrip.Name = "lbEncrip";
            this.lbEncrip.Size = new System.Drawing.Size(256, 95);
            this.lbEncrip.TabIndex = 1;
            // 
            // lbDecript
            // 
            this.lbDecript.FormattingEnabled = true;
            this.lbDecript.Location = new System.Drawing.Point(12, 214);
            this.lbDecript.Name = "lbDecript";
            this.lbDecript.Size = new System.Drawing.Size(256, 95);
            this.lbDecript.TabIndex = 3;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(59, 38);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(117, 23);
            this.btnEncriptar.TabIndex = 4;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnDecriptar
            // 
            this.btnDecriptar.Location = new System.Drawing.Point(59, 173);
            this.btnDecriptar.Name = "btnDecriptar";
            this.btnDecriptar.Size = new System.Drawing.Size(117, 23);
            this.btnDecriptar.TabIndex = 5;
            this.btnDecriptar.Text = "Decriptar";
            this.btnDecriptar.UseVisualStyleBackColor = true;
            this.btnDecriptar.Click += new System.EventHandler(this.btnDecriptar_Click);
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 321);
            this.Controls.Add(this.btnDecriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lbDecript);
            this.Controls.Add(this.lbEncrip);
            this.Controls.Add(this.txtTexto);
            this.Name = "FormRSA";
            this.Text = "FormRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ListBox lbEncrip;
        private System.Windows.Forms.ListBox lbDecript;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDecriptar;
    }
}