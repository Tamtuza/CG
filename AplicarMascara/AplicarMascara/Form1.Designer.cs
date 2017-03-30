namespace AplicarMascara
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgArvore = new System.Windows.Forms.PictureBox();
            this.imgSol = new System.Windows.Forms.PictureBox();
            this.imgMasc = new System.Windows.Forms.PictureBox();
            this.imgFinal = new System.Windows.Forms.PictureBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgArvore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // imgArvore
            // 
            this.imgArvore.Image = ((System.Drawing.Image)(resources.GetObject("imgArvore.Image")));
            this.imgArvore.Location = new System.Drawing.Point(12, 12);
            this.imgArvore.Name = "imgArvore";
            this.imgArvore.Size = new System.Drawing.Size(206, 204);
            this.imgArvore.TabIndex = 0;
            this.imgArvore.TabStop = false;
            // 
            // imgSol
            // 
            this.imgSol.Image = ((System.Drawing.Image)(resources.GetObject("imgSol.Image")));
            this.imgSol.Location = new System.Drawing.Point(244, 12);
            this.imgSol.Name = "imgSol";
            this.imgSol.Size = new System.Drawing.Size(206, 204);
            this.imgSol.TabIndex = 1;
            this.imgSol.TabStop = false;
            // 
            // imgMasc
            // 
            this.imgMasc.Image = ((System.Drawing.Image)(resources.GetObject("imgMasc.Image")));
            this.imgMasc.Location = new System.Drawing.Point(481, 12);
            this.imgMasc.Name = "imgMasc";
            this.imgMasc.Size = new System.Drawing.Size(206, 204);
            this.imgMasc.TabIndex = 2;
            this.imgMasc.TabStop = false;
            // 
            // imgFinal
            // 
            this.imgFinal.Location = new System.Drawing.Point(719, 12);
            this.imgFinal.Name = "imgFinal";
            this.imgFinal.Size = new System.Drawing.Size(206, 204);
            this.imgFinal.TabIndex = 3;
            this.imgFinal.TabStop = false;
            this.imgFinal.Click += new System.EventHandler(this.imgFinal_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(692, 260);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 309);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.imgFinal);
            this.Controls.Add(this.imgMasc);
            this.Controls.Add(this.imgSol);
            this.Controls.Add(this.imgArvore);
            this.Name = "Form1";
            this.Text = "Aplicar Máscara";
            ((System.ComponentModel.ISupportInitialize)(this.imgArvore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMasc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgArvore;
        private System.Windows.Forms.PictureBox imgSol;
        private System.Windows.Forms.PictureBox imgMasc;
        private System.Windows.Forms.PictureBox imgFinal;
        private System.Windows.Forms.Button btnAplicar;
    }
}

