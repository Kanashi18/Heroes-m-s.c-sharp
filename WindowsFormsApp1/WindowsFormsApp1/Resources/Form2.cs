using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Resources;

namespace WindowsFormsApp1.Resources
{
    
    public partial class FormUnitsMenu : Form
    {
        public Charter[] mas123 = new Charter[6];
        public PictureBox[] pb = new PictureBox[6];

        public FormUnitsMenu()
        {
            InitializeComponent();
        }

        private void FormUnitsMenu_Load(object sender, EventArgs e)
        {
            mas123 = new Charter[6];
            pb[0] = new PictureBox();
            pb[1] = new PictureBox();
            pb[2] = new PictureBox();
            pb[3] = new PictureBox();
            pb[4] = new PictureBox();
            pb[5] = new PictureBox();

            pb[0] = pictureBox1;
            pb[1] = pictureBox2;
            pb[2] = pictureBox3;
            pb[3] = pictureBox4;
            pb[4] = pictureBox5;

            Image img = Image.FromFile("D:\\Разбор файлов\\[arts]\\[anime]\\tyan\\withoutfon\\imgonline-com-ua-Resize-vh8czGlf7JB28yID.jpg");
            for (int i = 0; i < 6; i++)
            {
                mas123[i] = new Charter();
                mas123[i].setSettings("Jopa", i, i, i, i, i,img);
                pb[i].Image = mas123[i].charterImage;
            }
            
            

        }
        public void setit()
        {
            for (int i = 0; i < mas123.Length;i++)
            {
                pb[i].Image = mas123[i].charterImage;
            }
        }
    }
}
