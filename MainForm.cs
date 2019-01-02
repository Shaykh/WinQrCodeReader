using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ZXing;
using System.Windows.Forms;

namespace WinQrCodeReader
{
    public partial class MainForm : Form
    {
        IBarcodeReader barcodeReader;
        //TouchlessMgr touchlessMgr;

        private const int PREVIEW_WIDTH = 400;
        private const int PREVIEW_HEIGHT = 300;

        public MainForm()
        {
            InitializeComponent();
            Initialization();
        }

        private void Initialization()
        {
            barcodeReader = new BarcodeReader();
            
        }

        private void btImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Ouvrir l'image";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap loadedPicture = null;

                    try
                    {
                        loadedPicture = new Bitmap(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fichier non supporté : " + ex.Message);
                        throw;
                    }

                    pbCode.Image = loadedPicture;
                }
            }
        }
        
        private void btLire_Click(object sender, EventArgs e)
        {
            if (pbCode.Image == null)
            {
                MessageBox.Show("Veuillez charger une image !");
                return;
            }

            ReadCode((Bitmap)pbCode.Image);
        }
        
        private void ReadCode(Bitmap bitmap)
        {

            txtCodeType.Clear();
            txtContent.Clear();
            
            var result = barcodeReader.Decode(bitmap);
            if (result != null)
            {
                txtCodeType.Text = result.BarcodeFormat.ToString();
                txtContent.Text = result.Text;
            }
        }
    }
}
