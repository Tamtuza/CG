using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiltragemApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPassaAlta_Click(object sender, EventArgs e)
        {
            int media = 0;

            int r1, r2, r3, r4, r5;

            Bitmap img = new Bitmap(imgoriginal.Image);
            Bitmap img2 = new Bitmap(imgoriginal.Image);

            for (int i = 1; i < img.Height - 1; i++)
            {
                for (int j = 1; j < img.Width - 1; j++)
                {


                    r1 = (img.GetPixel(j - 1, i).G) * -1; // cima cruz
                    r2 = (img.GetPixel(j, i - 1).G) * -1; // lateral esquerda cruz
                    r3 = (img.GetPixel(j, i).G) * 4; // meio cruz
                    r4 = (img.GetPixel(j, i + 1).G) * -1; // lateral direita cruz
                    r5 = (img.GetPixel(j + 1, i).G) * -1; // baixo cruz

                    media = (r1 + r2 + r3 + r4 + r5);

                    if (media > 255) media = 255;
                    if (media < 0) media = 0;

                    img2.SetPixel(j, i, Color.FromArgb(255, media, media, media));

                }
            }

            imgoriginal.Image = img2;
        }
    }
}
