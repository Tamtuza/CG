using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiltragemApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------- Red/Blue ----------//        
        private void btnCor_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(imgtulipas.Image);

            for (int i = 0; i < img.Height / 2; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    img.SetPixel(j, i, Color.FromArgb(255, 0, 0, img.GetPixel(j, i).B));
                }
            }

            for (int i = img.Height / 2; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    img.SetPixel(j, i, Color.FromArgb(255, img.GetPixel(j, i).R, 0, 0));
                }
            }
            imgtulipasmod.Image = img;
        }

        //------------------------------------------------------------------------------- Escurecer ----------//
        private void btnEscurecer_Click(object sender, EventArgs e)
        {
            int red;
            int green;
            int blue;

            Bitmap img = new Bitmap(imgtulipas.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    red = img.GetPixel(j, i).R - 100;
                    green = img.GetPixel(j, i).G - 100;
                    blue = img.GetPixel(j, i).B - 100;
                    if (red < 0) red = 0;
                    if (green < 0) green = 0;
                    if (blue < 0) blue = 0;

                    img.SetPixel(j, i, Color.FromArgb(255, red, green, blue));
                }
            }
            imgtulipasmod.Image = img;
        }

        //------------------------------------------------------------------------------- Binarizar ----------//
        private void btnBinarizar_Click(object sender, EventArgs e)
        {
            int red;
            int green;
            int blue;
            int media;

            Bitmap img = new Bitmap(imgtulipas.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    red = img.GetPixel(j, i).R;
                    green = img.GetPixel(j, i).G;
                    blue = img.GetPixel(j, i).B;

                    media = (red + green + blue) / 3;

                    if (media > 128)
                    {
                        img.SetPixel(j, i, Color.FromArgb(255, 255, 255, 255));
                    }

                }
            }
            imgtulipasmod.Image = img;
        }
    }
}
