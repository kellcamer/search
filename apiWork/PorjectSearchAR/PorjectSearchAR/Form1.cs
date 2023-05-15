using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Xml;

namespace PorjectSearchAR
{
    public partial class Main : Form
    {

        public Main()
        {
/*            [DllImport("OziAPI.dll", CharSet = CharSet.Unicode)]---------------------------------------------------------------------------*/
            InitializeComponent();
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OziExpererApp_Load(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void eventNew_Click(object sender, EventArgs e)
        {
            try
            {

                //Process Ozi4Proc = new Process();
                //Ozi4Proc.StartInfo.FileName = "C:\\OziExplorer\\OziExpTrial.exe";
                //Ozi4Proc.EnableRaisingEvents = true;

                //Ozi4Proc.Start("C:\\OziExplorer\\OziExpTrial.exe", @"""..\demo.bmp""");

                //Ozi4Proc.WaitForExit();

                //You may want to perform different actions depending on the exit code.
                //Console.WriteLine("First process exited: " + Ozi4Proc.ExitCode);

                /*                Process secondProc = new Process();
                                secondProc.StartInfo.FileName = "mspaint.exe";
                                secondProc.Start();*/

                //Process.Start("C:\\OziExplorer\\OziExpTrial.exe", @"""C:\OziExplorer\Maps\Demo1.bmp""");

                Process.Start("mspaint", @"""C:\Users\dhugh\Desktop\PorjectSearchAR\PorjectSearchAR\PorjectSearchAR\nsmap.bmp""");

                //Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                //Bitmap OGbmp = new Bitmap("C:\\OziExplorer\\Maps\\Demo1.bmp");

                //Bitmap OGbmp = new Bitmap(@"C:\\OziExplorer\\Maps\\Demo1.bmp");

                // Create a new Graphics
                //Graphics graphics = Graphics.FromImage(OGbmp);


                //graphics.DrawImage(OGbmp , 0, 0);

                // Initialize a pen
                //Pen pen = new Pen(Color.Red, 5);

                // Draw a rectangle
                // graphics.DrawEllipse(pen, new Rectangle(0, 0, 700, 700));

                // Save the file
                //OGbmp.Save(@"C:\\Users\\dhugh\\Desktop\\PorjectSearchAR\\PorjectSearchAR\\PorjectSearchAR\\output.png");

                // Create pen.
                // Pen blackPen = new Pen(Color.Black, 3);

                // Create location and size of rectangle.
                // int x = 0;
                //int y = 0;
                //int width = 200;
                //int height = 200;

                //graphics.DrawRectangle(blackPen, x, y, width, height);

                //int width = 640;
                //int height = 480;
                //Bitmap bmp = new Bitmap(width, height);

                // Create a red pen
                //Pen redPen = new Pen(Color.Red, 5);

                // Create a graphics object from the bitmap
                //Graphics g = Graphics.FromImage(bmp);

                // Draw a rectangle on the bitmap
                //g.DrawRectangle(redPen, new Rectangle(100, 100, 200, 150));

                // Save the bitmap as a BMP file
                //bmp.Save("..\red_rectangle.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                // Clean up
                //g.Dispose();
                //redPen.Dispose();
                //bmp.Dispose();

                int firstX = int.Parse(textBox1.Text);
                int firstY = int.Parse(textBox5.Text);
                int lastX = int.Parse(textBox2.Text);
                int lastY = int.Parse(textBox6.Text);


                // Initialize Bitmap object
                Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Bitmap OGbmp = new Bitmap(1320, 846, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                Image image = new Bitmap(@"C:\Users\dhugh\Desktop\PorjectSearchAR\PorjectSearchAR\PorjectSearchAR\nsmap.bmp");

                // Create a new Graphics
                Graphics graphics = Graphics.FromImage(bitmap);

                Graphics graphics2 = Graphics.FromImage(OGbmp);

                // Initialize a pen
                Pen pen = new Pen(Color.Red, 5);

                Pen pen2 = new Pen(Color.Blue, 5);

                Pen pen3 = new Pen(Color.Green, 5);

                SolidBrush blueBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));

                // Draw a rectangle
                graphics.DrawEllipse(pen, new Rectangle(0, 0, 700, 700));
                
                graphics2.DrawEllipse(pen, new Rectangle(0, 0, 700, 700));

                graphics2.DrawImage(image, 0, 0);

                //graphics2.DrawRectangle(pen3, 0, 0, 700, 700);

                // Create array of points that define lines to draw.
                Point[] points =
                         {
                 new Point(firstX,  firstY),
                 new Point(lastX, lastY),
             };
                //graphics2.FillRectangle(blueBrush, firstX, firstY , 250 + 50, 300 + 50);


                //Draw lines to screen.
                float spacing = (float)DetermineLength(points[0], points[1]);
                graphics2.DrawLine(pen, points[0].X, points[0].Y , points[1].X, points[1].Y);
                graphics2.DrawLines(pen2, points);

                //perindicular
                graphics2.DrawLine(pen, points[0].X, points[1].Y, points[1].X, points[0].Y);

                // Save the file
                OGbmp.Save(@"C:\Users\dhugh\Desktop\PorjectSearchAR\PorjectSearchAR\PorjectSearchAR\output2.bmp");

                bitmap.Save(@"C:\Users\dhugh\Desktop\PorjectSearchAR\PorjectSearchAR\PorjectSearchAR\output.bmp");

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred!!!: " + ex.Message);
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("TESTING TESTING 123");
            /*            oziCreateWP();--------------------------------------------------------------------------------------------*/
            /*            System.Drawing.Point(50, 100);*/
            // Create pen.
            /*           Pen blackPen = new Pen(Color.Black, 3);

                       // Create rectangle.
                       Rectangle rect = new Rectangle(0, 0, 200, 200);

                       // Draw rectangle to screen.
                       e.Graphics.DrawRectangle(blackPen, rect);*/


        }


        public int DetermineSlope(Point firstpoint, Point secondpoint,Pen pen, Graphics graphic)
        {
            int slope = 1;
            slope = -1/(firstpoint.Y - secondpoint.Y / firstpoint.X - secondpoint.X);

            graphic.DrawLine(pen, firstpoint.X, secondpoint.Y, secondpoint.X, firstpoint.Y);

            return slope;
        }

        public double DetermineLength(Point firstpoint, Point secondpoint)
        {
            double sqlength = 0, length = 0;
            sqlength = ((secondpoint.X - firstpoint.X) * (secondpoint.X - firstpoint.X)) + ((secondpoint.Y - firstpoint.Y) * (secondpoint.Y - firstpoint.Y));
            length = Math.Sqrt(sqlength);
            return length;
        }



    }


}
