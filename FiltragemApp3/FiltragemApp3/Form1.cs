using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiltragemApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscCinza_Click(object sender, EventArgs e)
        {
            int red;
            int green;
            int blue;
            int media;

            Bitmap img = new Bitmap(imgOriginal.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    red = img.GetPixel(j, i).R;
                    green = img.GetPixel(j, i).G;
                    blue = img.GetPixel(j, i).B;

                    media = (red + green + blue) / 3;

                    if (media > 255)
                    {
                        img.SetPixel(j, i, Color.FromArgb(255, 255, 255, 255));
                    }
                    else
                        if (media < 0)
                        {
                            img.SetPixel(j, i, Color.FromArgb(255, 0, 0, 0));
                        }
                        else
                        {
                            img.SetPixel(j, i, Color.FromArgb(255, media, media, media));
                        }
                }
            }
            imgCinza.Image = img;
        }

        private void btnLimiar_Click(object sender, EventArgs e)
        {
            int cor;

            Bitmap img = new Bitmap(imgCinza.Image);
            Bitmap img1 = new Bitmap(imgCinza.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    cor = img.GetPixel(j, i).R;

                    if (cor > 100)
                    {
                        img1.SetPixel(j, i, Color.FromArgb(255, 255, 255, 255));
                    }
                    else
                    {
                        img1.SetPixel(j, i, Color.FromArgb(255, 0, 0, 0));
                    }
                }
            }
            imgLimiar.Image = img1;
        }

        private void btnDilatar_Click(object sender, EventArgs e) //Dilatação & Erosão
        {
            int pos;

            Bitmap img = new Bitmap(imgLimiar.Image);
            Bitmap img1 = new Bitmap(imgLimiar.Image);

            for (int i = 1; i < img.Height; i++)  //Dilatação: (A + B);
            {
                for (int j = 1; j < img.Width; j++)
                {
                    pos = img.GetPixel(j, i).R;

                    if (pos == 0)
                    {
                        img1.SetPixel(j - 1, i - 1, Color.FromArgb(255, 0, 0, 0));
                        img1.SetPixel(j - 1, i, Color.FromArgb(255, 0, 0, 0));
                        img1.SetPixel(j, i - 1, Color.FromArgb(255, 0, 0, 0));
                        img1.SetPixel(j, i, Color.FromArgb(255, 0, 0, 0));
                    }
                }
            }

            imgDilatada.Image = img1;
        }

        private void btnErodir_Click(object sender, EventArgs e)
        {
            int pos1, pos2, pos3, pos4;

            Bitmap img1 = new Bitmap(imgDilatada.Image);
            Bitmap img2 = new Bitmap(imgErodida.Image);

            for (int i = 1; i < img1.Height; i++)  //Erosão: [(A + B) - B];
            {
                for (int j = 1; j < img1.Width; j++)
                {
                    pos1 = img1.GetPixel(j - 1, i - 1).R;
                    pos2 = img1.GetPixel(j - 1, i).R;
                    pos3 = img1.GetPixel(j, i - 1).R;
                    pos4 = img1.GetPixel(j, i).R;

                    if (pos1 == 0)
                    {
                        if (pos2 == 0)
                        {
                            if (pos3 == 0)
                            {
                                if (pos4 == 0)
                                {
                                    img2.SetPixel(j, i, Color.FromArgb(255, 0, 0, 0));
                                }
                            }
                        }
                    }
                }
            }

            imgErodida.Image = img2;
        }
    }
}
