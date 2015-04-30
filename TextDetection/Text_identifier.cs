using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.OCR;
using Emgu.CV.UI;
using Emgu.Util;

namespace TextDetection
{
    public partial class Text_identifier : Form
    {
        Tesseract tess;

        Image<Bgr, Byte> emgu_inputImage=null;
       
        Image<Bgr, Byte> blank = null;
        public Text_identifier()
        {
            InitializeComponent();

            try
            {
                tess = new Tesseract("tessdata", "eng", Tesseract.OcrEngineMode.OEM_DEFAULT);
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        private void buttonCrop_Click(object sender, EventArgs e)
        {

        }

        //this function is used to rotate the image in clockwise direction

        private void btn_rotateClock_Click(object sender, EventArgs e)
        {
            emgu_inputImage = emgu_inputImage.Rotate(90, new Bgr(Color.Black));
            inputImagebox.Image = emgu_inputImage;
        }

        //this function is used to rotate the image in anti-clockwise direction

        private void btn_rotateAntiClock_Click(object sender, EventArgs e)
        {
            emgu_inputImage = emgu_inputImage.Rotate(-90, new Bgr(Color.Black));
            inputImagebox.Image = emgu_inputImage;
        }

        //this function is used to upload an image to the picturebox by clicking the button

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog uploadPic = new OpenFileDialog();


            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                inputImagebox.ImageLocation = uploadPic.FileName;
                emgu_inputImage = new Image<Bgr, byte>(uploadPic.FileName);
                MessageBox.Show(uploadPic.FileName);

            }

        }


        // Use to save the text in text box or outputbox as text file

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string input = OutputTextBox.Text.ToString();
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path, input);


        }

      


        private void inputImagebox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var textID_home = new MainMenu();
            textID_home.Show();

        }
       
        
         


        private void ButtonScan_Click(object sender, EventArgs e)
        {
            string one;
           
            
            inputImagebox.Image = blank;
            Application.DoEvents();
            tess.Recognize(emgu_inputImage);
            one = tess.GetText();
            inputImagebox.Image = emgu_inputImage;

            MessageBox.Show(one);
           


            


        }

       
    }

}


       
    

