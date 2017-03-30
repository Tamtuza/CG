using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiltragemApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox2.Image);
            int cont = 100;

            for (int i = 2; i < img.Width - 2; i++)
            {
                for (int j = 2; j < img.Height - 2; j++)
                {

                    if (((i >= 200) && (i <= 320)) && ((j >= 92) && (j <= 140))) j += 100;

                    switch (i)
                    {
                        case 192:
                            cont = 70;
                            break;
                        case 382:
                            cont = 70;
                            break;
                        case 573:
                            cont = 100;
                            break;
                    }

                    int aux1 = img.GetPixel(i, j - 2).R * cont;
                    int aux2 = img.GetPixel(i, j - 1).R * cont / 2;
                    int aux3 = img.GetPixel(i + 2, j).R * cont;
                    int aux4 = img.GetPixel(i + 1, j).R * cont / 2;
                    int aux5 = img.GetPixel(i, j + 2).R * cont;
                    int aux6 = img.GetPixel(i, j + 1).R * cont / 2;
                    int aux7 = img.GetPixel(i - 2, j).R * cont;
                    int aux8 = img.GetPixel(i - 1, j).R * cont / 2;
                    int aux9 = img.GetPixel(i, j).R * 0;
                    int dividendo = (cont * 4) / 4 + (cont * 4);

                    int media = (aux1 + aux2 + aux3 + aux4 + aux5 + aux6 + aux7 + aux8 + aux9) / dividendo;

                    if (media > 255) media = 255;
                    if (media < 0) media = 0;

                    img.SetPixel(i, j, Color.FromArgb(255, media, media, media));
                }
            }
            pictureBox3.Image = img;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);


            for (int j = 0; j < img.Height; j++)
            {
                for (int i = 0; i < img.Width; i++)
                {

                    int media = (img.GetPixel(i, j).R + img.GetPixel(i, j).G + img.GetPixel(i, j).B) / 3;
                    img.SetPixel(i, j, Color.FromArgb(255, media, media, media));
                }
            }
            pictureBox2.Image = img;
        }
    }
}
