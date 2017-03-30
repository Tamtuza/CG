using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicarMascara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            int r, g, b;

            Bitmap img = new Bitmap(imgMasc.Image);
            Bitmap img2 = new Bitmap(imgArvore.Image);
            Bitmap img3 = new Bitmap(imgSol.Image);

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    if ((img.GetPixel(j, i).R == 0))
                    {
                        r = img3.GetPixel(j, i).R;
                        g = img3.GetPixel(j, i).G;
                        b = img3.GetPixel(j, i).B;
                        img2.SetPixel(j, i, Color.FromArgb(255, r, g, b));
                    }
                }
            }
            imgFinal.Image = img2;
        }

        private void imgFinal_Click(object sender, EventArgs e)
        {

        }
    }
}
