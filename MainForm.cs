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
        public MainForm()
        {
            InitializeComponent();
        }

        private void ReadBarcode()
        {
            IBarcodeReader barcodeReader = new BarcodeReader();
            TouchlessMgr touchlessMgr = new TouchlessMgr();

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
    }
}
