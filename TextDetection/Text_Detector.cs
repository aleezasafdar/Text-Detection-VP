using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace TextDetection
{
    public partial class Text_Detector : Form
    {
        BitmapToPixConverter temp;
        int x, y, width, height;
        Pix processedImg;
        TesseractEngine ScanningFile;
        Bitmap EditableIMG;
        Bitmap B_SOURCE;
        Pix Pix_Source;
        
        

        public Text_Detector()
        {
            InitializeComponent();
        }
//clockwise rotation Button
        private void btn_rotateClock_Click(object sender, EventArgs e)
        {

            processedImg = processedImg.Rotate((float)4.71);
            PixToBitmapConverter convert = new PixToBitmapConverter();
            inputImageBox.Image = convert.Convert(processedImg);

        }
        //Anticlockwise rotation functionality
        private void btn_rotateAntiClock_Click(object sender, EventArgs e)
        {
            processedImg = processedImg.Rotate((float)-4.71);
            PixToBitmapConverter convert = new PixToBitmapConverter();
            inputImageBox.Image = convert.Convert(processedImg);

        }

        //functionality behind upload button
        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            
                OpenFileDialog uploadPic = new OpenFileDialog();

                if (uploadPic.ShowDialog() == DialogResult.OK)
                {
                    inputImageBox.ImageLocation = uploadPic.FileName;
                    processedImg = Pix.LoadFromFile(uploadPic.FileName);
                    PixToBitmapConverter converter = new PixToBitmapConverter();
                    EditableIMG = converter.Convert(processedImg);
                    Pix_Source = processedImg;
                    B_SOURCE = EditableIMG;
                    processedImg = processedImg.ConvertRGBToGray(0, 0, 0);

                }
            
            
        }
        //functionality behind Scan button
        private void ButtonScan_Click(object sender, EventArgs e)
        {
            try
            {
                string output;

                double Confidence;
                ScanningFile = new TesseractEngine("tessdata", "eng", EngineMode.TesseractAndCube); // Cube is another engine in comparison
                //with Tesseract, it consumes more resources, slower, but gives better results. 

                var tessImage = ScanningFile.Process(processedImg);

                output = tessImage.GetText();
                Confidence = tessImage.GetMeanConfidence();
                Confidence = Confidence * 100;
                OutputTextBox.Text = output;
                Confidencebox.Text = Confidence.ToString();
            }
            catch(Exception ex)
            {
                Console.Write("Upload an image '{0}", ex);
            }


        }



        //functionality save button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter save;
            SaveFileDialog file = new SaveFileDialog();
            string input = OutputTextBox.ToString();
            if (file.ShowDialog() == DialogResult.OK)
            {
                save = new StreamWriter(file.FileName);
                save.Write(input);
                save.Close();
            }

        }

        private void Mainmenu_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            var home = new MainMenu();

            home.Show();
        }

        //crop button function

        private void Cropbtn_Click(object sender, EventArgs e)
        {


            Rectangle one = new Rectangle(x, y, width, height);

            EditableIMG = cropAtRect(EditableIMG, one);
            inputImageBox.Image = EditableIMG;
            temp = new BitmapToPixConverter();
            processedImg = temp.Convert(EditableIMG);

        }
        //function of crop used in crop click function

        public Bitmap cropAtRect(Bitmap b, Rectangle r)
        {
            b = ResizeBitmap(b, inputImageBox.Width, inputImageBox.Height);
            Bitmap nb = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(nb);
            g.DrawImage(b, -r.X, -r.Y);
            return nb;

        }
        //functionality behind Blurr button

        private Bitmap ImageBlurFilter(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = null;
            resultBitmap = ConvolutionFilter(sourceBitmap, Median9x9, 1.0 / 81.0, 0);
            return resultBitmap;
        }

        private double[,] Median9x9
        {
            get
            {
                return new double[,]  
                { { 1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1}, };
            }
        }

        private Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    blue = (blue > 255 ? 255 :
                           (blue < 0 ? 0 :
                            blue));

                    green = (green > 255 ? 255 :
                            (green < 0 ? 0 :
                             green));

                    red = (red > 255 ? 255 :
                          (red < 0 ? 0 :
                           red));

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                 PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private void blurBtn_Click(object sender, EventArgs e)
        {
            EditableIMG = ImageBlurFilter(EditableIMG);
            inputImageBox.Image = EditableIMG;
            BitmapToPixConverter temp = new BitmapToPixConverter();
            processedImg = temp.Convert(EditableIMG);

        }
        //sepia click function

        private void sepiaBtn_Click(object sender, EventArgs e)
        {
            Bitmap tempSepia = new Bitmap(EditableIMG.Width, EditableIMG.Height);
            ColorMatrix matrix = new ColorMatrix(new float[][]{new float[] {0.393f, 0.769f, 0.189f, 0, 0},
                                                               new float[] {0.349f, 0.686f, 0.168f, 0, 0},
                                                               new float[] {0.272f, 0.534f, 0.131f, 0, 0},
                                                               new float[] { 0, 0,0, 1, 0},
                                                               new float[] {0,0,0, 0, 0}});

            ImageAttributes attributes = new ImageAttributes();



            attributes.SetColorMatrix(matrix);

            Graphics graphics = Graphics.FromImage(tempSepia);
            graphics.DrawImage(EditableIMG, new Rectangle(0, 0, tempSepia.Width, tempSepia.Height), 0, 0, tempSepia.Width, tempSepia.Height, GraphicsUnit.Pixel, attributes);

            graphics.Dispose();
            EditableIMG = tempSepia;
            inputImageBox.Image = EditableIMG;
            temp = new BitmapToPixConverter();
            processedImg = temp.Convert(EditableIMG);

        }
        //mouse events to draw a rectangle using diagnals to crop an image
        private void inputImageBox_MouseDown(object sender, MouseEventArgs e)
        {
            {
                x = e.X;
                y = e.Y;
            }


        }

        private void inputImageBox_MouseUp(object sender, MouseEventArgs e)
        {
            {
                width = e.X - x;
                height = e.Y - y;
            }

        }

        private Bitmap ResizeBitmap(Bitmap sourceBMP, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(sourceBMP, 0, 0, width, height);
            }

            return result;
        }
        // function used to sharp an image
        public static Bitmap sharpen(Bitmap image)
        {
            Bitmap sharpenImage = new Bitmap(image.Width, image.Height);

            int filterWidth = 3;
            int filterHeight = 3;
            int w = image.Width;
            int h = image.Height;

            double[,] filter = new double[filterWidth, filterHeight];

            filter[0, 0] = filter[0, 1] = filter[0, 2] = filter[1, 0] = filter[1, 2] = filter[2, 0] = filter[2, 1] = filter[2, 2] = -1;
            filter[1, 1] = 9;

            double factor = 1.0;
            double bias = 0.0;

            Color[,] result = new Color[image.Width, image.Height];

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    double red = 0.0, green = 0.0, blue = 0.0;


                    Color imageColor = image.GetPixel(x, y);

                    for (int filterX = 0; filterX < filterWidth; filterX++)
                    {
                        for (int filterY = 0; filterY < filterHeight; filterY++)
                        {
                            int imageX = (x - filterWidth / 2 + filterX + w) % w;
                            int imageY = (y - filterHeight / 2 + filterY + h) % h;


                            imageColor = image.GetPixel(imageX, imageY);

                            red += imageColor.R * filter[filterX, filterY];
                            green += imageColor.G * filter[filterX, filterY];
                            blue += imageColor.B * filter[filterX, filterY];
                        }
                        int r = Math.Min(Math.Max((int)(factor * red + bias), 0), 255);
                        int g = Math.Min(Math.Max((int)(factor * green + bias), 0), 255);
                        int b = Math.Min(Math.Max((int)(factor * blue + bias), 0), 255);

                        result[x, y] = Color.FromArgb(r, g, b);
                    }
                }
            }
            for (int i = 0; i < w; ++i)
            {
                for (int j = 0; j < h; ++j)
                {
                    sharpenImage.SetPixel(i, j, result[i, j]);
                }
            }
            return sharpenImage;
        }
        //functionality behind the sharp button

        private void Sharp_btn_Click(object sender, EventArgs e)
        {
            EditableIMG = sharpen(EditableIMG);
            inputImageBox.Image = EditableIMG;
            BitmapToPixConverter temp = new BitmapToPixConverter();
            processedImg = temp.Convert(EditableIMG);

        }
        //to undo all changes made to the image
        private void Defaultbtn_Click(object sender, EventArgs e)
        {
            EditableIMG = B_SOURCE;
            processedImg = Pix_Source;
            inputImageBox.Image= B_SOURCE;
        }
       
        }
        }

      
       
    

