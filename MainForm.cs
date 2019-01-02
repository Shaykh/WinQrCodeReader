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
            touchlessMgr = new TouchlessMgr();
            
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

        private void btWebcam_Click(object sender, EventArgs e)
        {
            if (btWebcam.Text.Equals("Démarrer Webcam"))
            {
                btWebcam.Text = "Arrêter Webcam";
                StartCamera();
            }
            else
            {
                btWebcam.Text = "Démarrer Webcam";
                StopCamera();
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

        private void StartCamera()
        {
            if (touchlessMgr.Cameras.Count == 0)
            {
                MessageBox.Show("Aucune webcam n'a été détecté!");
                btWebcam.Text = "Démarrer Webcam";
                return;
            }

            touchlessMgr.CurrentCamera = touchlessMgr.Cameras[0];
            touchlessMgr.CurrentCamera.OnImageCaptured += new EventHandler<CameraEventArgs>(OnImageCaptured);

        }

        private void OnImageCaptured(object sender, CameraEventArgs e)
        {
            Bitmap capturedImage = e.Image;

            this.Invoke((MethodInvoker)delegate
            {
                pbCode.Image = capturedImage;

                ReadCode(capturedImage);
            }
            );
        }

        private void StopCamera()
        {
            btWebcam.Text = "Démarrer Webcam";

            if (touchlessMgr.CurrentCamera != null)
            {
                touchlessMgr.CurrentCamera.OnImageCaptured -= new EventHandler<CameraEventArgs>(OnImageCaptured);
            }
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
