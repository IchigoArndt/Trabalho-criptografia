namespace TrabCrip.apresentacao
{
    partial class menuPrincipal
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
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnSHA = new System.Windows.Forms.Button();
            this.btnRSHA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(39, 3);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(101, 23);
            this.btnRSA.TabIndex = 0;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnSHA
            // 
            this.btnSHA.Location = new System.Drawing.Point(39, 71);
            this.btnSHA.Name = "btnSHA";
            this.btnSHA.Size = new System.Drawing.Size(101, 23);
            this.btnSHA.TabIndex = 1;
            this.btnSHA.Text = "SHA 256";
            this.btnSHA.UseVisualStyleBackColor = true;
            this.btnSHA.Click += new System.EventHandler(this.btnSHA_Click);
            // 
            // btnRSHA
            // 
            this.btnRSHA.Location = new System.Drawing.Point(39, 134);
            this.btnRSHA.Name = "btnRSHA";
            this.btnRSHA.Size = new System.Drawing.Size(101, 23);
            this.btnRSHA.TabIndex = 2;
            this.btnRSHA.Text = "RSA + SHA 256";
            this.btnRSHA.UseVisualStyleBackColor = true;
            this.btnRSHA.Click += new System.EventHandler(this.btnRSHA_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 159);
            this.Controls.Add(this.btnRSHA);
            this.Controls.Add(this.btnSHA);
            this.Controls.Add(this.btnRSA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "menuPrincipal";
            this.Text = "Criptografia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnSHA;
        private System.Windows.Forms.Button btnRSHA;
    }
}

