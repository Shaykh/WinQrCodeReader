using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using TouchlessLib;
using ZXing;
using System.Windows.Forms;

namespace WinQrCodeReader
{
    public partial class MainForm : Form
    {
        IBarcodeReader barcodeReader;
        TouchlessMgr touchlessMgr;

        public MainForm()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            barcodeReader = new BarcodeReader();
            touchlessMgr = new TouchlessMgr();
            
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Ouvrir l'image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;

                    try
                    {
                        bitmap = new Bitmap(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fichier non supporté : " + ex.Message);
                        throw;
                    }

                    pbCode.Image = bitmap;
                }
            }
        }

        private void btWebcam_Click(object sender, EventArgs e)
        {

        }

        private void btLire_Click(object sender, EventArgs e)
        {
            if (pbCode.Image == null)
            {
                MessageBox.Show("Veuillez charger une image !");
                return;
            }

            txtCodeType.Clear();
            txtContent.Clear();

            string code = ReadCode((Bitmap)pbCode.Image);
            if (!string.IsNullOrWhiteSpace(code))
            {
                txtContent.Text = code;
            }
        }

        

        private string ReadCode(Bitmap bitmap)
        {
            string results = string.Empty;
            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                txtCodeType.Text = result.BarcodeFormat.ToString();
                results = result.Text;
            }
            return results;
        }
    }
}
