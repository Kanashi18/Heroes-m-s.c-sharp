using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool reimage = false;
        public int x1 = 10, y1=10;
        public const int width = 15, height = 25, k = 15;
        public Bitmap bitfield = new Bitmap(k * (width + 1) + 1, k * (height + 3) + 1);



        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new Resources.FormUnitsMenu();
            f1.Show();
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Bitmap flag = new Bitmap(200, 100);
            Graphics flagGraphics = Graphics.FromImage(flag);
            int red = 0;
            int white = 11;
            Image newImage = Image.FromFile(
                    "D:\\Разбор файлов\\[arts]\\[anime]\\tyan\\withoutfon\\imgonline-com-ua-Resize-5YvMwX95So.png"
                );
            Image newtyanImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(newtyanImage);
            gr.DrawImage(newImage, new Point(x1,y1));
            x1 += 10;
            y1 += 10;
            while (white <= 100)
            {
                
                flagGraphics.FillRectangle(Brushes.Red, 100, red, 200, 10);
                flagGraphics.FillRectangle(Brushes.White, 100, white, 200, 10);
                red += 20;
                white += 20;
            }
            if (reimage == false)
            {
                reimage = true;
                pictureBox1.Image = flag;
            }
            else
            {
                reimage = false;
                pictureBox1.Image = newtyanImage;
            }

        }
        /*private void pictureBox1_MouseDown(object sender, MouseEventArgs me)
        {
            Image b = pictureBox1.Image;
            int x = b.Width * me.X / pictureBox1.Width;
            int y = b.Height * me.Y / pictureBox1.Height;
            MessageBox.Show(String.Format("X={0}, Y={1}", x, y));
        }*/
    }
}
