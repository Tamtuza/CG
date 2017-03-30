using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesenhaFormas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Desenha linha traçada/riscada
        private void btnRiscar_Click(object sender, EventArgs e)
        {
            Bitmap img1 = new Bitmap(imgbranca.Image);

            int x = 50;

            do
            {
                for (int y = 0; y < 10; y++)
                {
                    img1.SetPixel(250, (x + y), Color.FromArgb(255, 0, 0, 0));
                }

                x = x + 20;

            } while (x < 350);

            imgbranca.Image = img1;
        }

        //Desenha Linhas perpendiculares
        private void btnLinhas_Click(object sender, EventArgs e)
        {
            Bitmap img2 = new Bitmap(imgbranca.Image);

            for (int x = 150; x < 200; x++)
            {
                img2.SetPixel((x + 20), 175, Color.FromArgb(255, 0, 0, 0));
                img2.SetPixel(150, x, Color.FromArgb(255, 0, 0, 0));
            }

            imgbranca.Image = img2;
        }

        //Desenha Cruz
        private void btnCruz_Click(object sender, EventArgs e)
        {
            Bitmap img3 = new Bitmap(imgbranca.Image);

            for (int x = 100; x < 300; x++)
            {
                for (int y = 200; y < 300; y++)
                {
                    img3.SetPixel(y, x, Color.FromArgb(255, 0, 0, 0));
                }
            }

            for (int y = 150; y < 250; y++)
            {
                for (int x = 100; x < 400; x++)
                {
                    img3.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                }
            }

            imgbranca.Image = img3;
        }

        private void imgbranca_Click(object sender, EventArgs e)
        {

        }
    }
}
