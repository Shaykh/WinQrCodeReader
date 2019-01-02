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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodeType = new System.Windows.Forms.TextBox();
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
            this.btImage.Click += new System.EventHandler(this.btImage_Click);
            // 
            // btWebcam
            // 
            this.btWebcam.Location = new System.Drawing.Point(180, 20);
            this.btWebcam.Name = "btWebcam";
            this.btWebcam.Size = new System.Drawing.Size(120, 40);
            this.btWebcam.TabIndex = 2;
            this.btWebcam.Text = "Démarrer Webcam";
            this.btWebcam.UseVisualStyleBackColor = true;
            this.btWebcam.Click += new System.EventHandler(this.btWebcam_Click);
            // 
            // btLire
            // 
            this.btLire.Location = new System.Drawing.Point(320, 20);
            this.btLire.Name = "btLire";
            this.btLire.Size = new System.Drawing.Size(120, 40);
            this.btLire.TabIndex = 3;
            this.btLire.Text = "Lire Code";
            this.btLire.UseVisualStyleBackColor = true;
            this.btLire.Click += new System.EventHandler(this.btLire_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(160, 396);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(280, 20);
            this.txtContent.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contenu du code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type de code";
            // 
            // txtCodeType
            // 
            this.txtCodeType.Location = new System.Drawing.Point(161, 426);
            this.txtCodeType.Name = "txtCodeType";
            this.txtCodeType.Size = new System.Drawing.Size(280, 20);
            this.txtCodeType.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
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
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeType;
    }
}

