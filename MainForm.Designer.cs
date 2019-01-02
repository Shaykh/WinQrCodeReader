namespace WinQrCodeReader
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCode = new System.Windows.Forms.PictureBox();
            this.btImage = new System.Windows.Forms.Button();
            this.btWebcam = new System.Windows.Forms.Button();
            this.btLire = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCode
            // 
            this.pbCode.Location = new System.Drawing.Point(40, 80);
            this.pbCode.Name = "pbCode";
            this.pbCode.Size = new System.Drawing.Size(400, 300);
            this.pbCode.TabIndex = 0;
            this.pbCode.TabStop = false;
            // 
            // btImage
            // 
            this.btImage.Location = new System.Drawing.Point(40, 20);
            this.btImage.Name = "btImage";
            this.btImage.Size = new System.Drawing.Size(120, 40);
            this.btImage.TabIndex = 1;
            this.btImage.Text = "Charger Image";
            this.btImage.UseVisualStyleBackColor = true;
            // 
            // btWebcam
            // 
            this.btWebcam.Location = new System.Drawing.Point(180, 20);
            this.btWebcam.Name = "btWebcam";
            this.btWebcam.Size = new System.Drawing.Size(120, 40);
            this.btWebcam.TabIndex = 2;
            this.btWebcam.Text = "Démarrer Webcam";
            this.btWebcam.UseVisualStyleBackColor = true;
            // 
            // btLire
            // 
            this.btLire.Location = new System.Drawing.Point(320, 20);
            this.btLire.Name = "btLire";
            this.btLire.Size = new System.Drawing.Size(120, 40);
            this.btLire.TabIndex = 3;
            this.btLire.Text = "Lire Code";
            this.btLire.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btLire);
            this.Controls.Add(this.btWebcam);
            this.Controls.Add(this.btImage);
            this.Controls.Add(this.pbCode);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCode;
        private System.Windows.Forms.Button btImage;
        private System.Windows.Forms.Button btWebcam;
        private System.Windows.Forms.Button btLire;
        private System.Windows.Forms.TextBox textBox1;
    }
}

