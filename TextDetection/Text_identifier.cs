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



namespace TextDetection
{
    public partial class Text_identifier : Form
    {
        static Image undoImage;
        private Bitmap OriginalImage;
        private bool IsSelecting = false;
        private int X0, Y0, X1, Y1;

        public Text_identifier()
        {
            InitializeComponent();
        }

        private void buttonCrop_Click(object sender, EventArgs e)
        {
            
        }

        //this function is used to rotate the image in clockwise direction
 
        private void btn_rotateClock_Click(object sender, EventArgs e)
        {
            Image img = inputImagebox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            inputImagebox.Image = img;
        }

        //this function is used to rotate the image in anti-clockwise direction

        private void btn_rotateAntiClock_Click(object sender, EventArgs e)
        {
            Image img = inputImagebox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipXY);
            inputImagebox.Image = img;
        }

        //this function is used to upload an image to the picturebox by clicking the button

        private void buttonUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog uploadPic = new OpenFileDialog();


            if (uploadPic.ShowDialog() == DialogResult.OK)
            {
                inputImagebox.ImageLocation = uploadPic.FileName;


            }
 
        }


        // Use to save the text in text box or outputbox as text file

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text.ToString();
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            File.WriteAllText(path, input);


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

//Selecting the area using MOUSEDOWN , MOUSEMOVE and MOUSE UP

        private void inputImagebox_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelecting = true;

            // Save the start point.
            X0 = e.X;
            Y0 = e.Y;

           OriginalImage = (Bitmap)inputImagebox.Image;
           undoImage = inputImagebox.Image;
        }

        private void inputImagebox_MouseMove(object sender, MouseEventArgs e)
        {

            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;

            // Save the new point.
            X1 = e.X;
            Y1 = e.Y;

            // Make a Bitmap to display the selection rectangle.
            Bitmap bm = new Bitmap(OriginalImage);

            // Draw the rectangle that wil select the area
            using (Graphics gr = Graphics.FromImage(bm))
            {

                gr.DrawRectangle(Pens.Black,
                    Math.Min(X0, X1), Math.Min(Y0, Y1),
                    Math.Abs(X0 - X1), Math.Abs(Y0 - Y1));


            }

            // Display the temporary bitmap.
            inputImagebox.Image = bm;
        }

        private void inputImagebox_MouseUp(object sender, MouseEventArgs e)
        {
            // Do nothing it we're not selecting an area.
            if (!IsSelecting) return;
            IsSelecting = false;

            // Display the original image.
            inputImagebox.Image = OriginalImage;

            // Copy the selected part of the image.
            int wid = Math.Abs(X0 - X1);
            int hgt = Math.Abs(Y0 - Y1);
            if ((wid < 1) || (hgt < 1)) return;

            Bitmap area = new Bitmap(wid, hgt);
            using (Graphics gr = Graphics.FromImage(area))
            {
                Rectangle source_rectangle =
                    new Rectangle(Math.Min(X0, X1), Math.Min(Y0, Y1),
                        wid, hgt);
                Rectangle dest_rectangle =
                    new Rectangle(0, 0, wid, hgt);
                gr.DrawImage(OriginalImage, dest_rectangle,
                    source_rectangle, GraphicsUnit.Pixel);
            }

            // Display the result.
            inputImagebox.Image = area;
        }
        //Undo the changes made in image
        private void buttonUndo_Click(object sender, EventArgs e)
        {
            inputImagebox.Image = undoImage;
           
        }

        private void inputImagebox_Click(object sender, EventArgs e)
        {

        }





       
    }
}
