namespace FiltragemApp3
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
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.imgCinza = new System.Windows.Forms.PictureBox();
            this.btnEscCinza = new System.Windows.Forms.Button();
            this.btnLimiar = new System.Windows.Forms.Button();
            this.btnDilatar = new System.Windows.Forms.Button();
            this.imgLimiar = new System.Windows.Forms.PictureBox();
            this.btnErodir = new System.Windows.Forms.Button();
            this.imgDilatada = new System.Windows.Forms.PictureBox();
            this.imgErodida = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCinza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDilatada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErodida)).BeginInit();
            this.SuspendLayout();
            // 
            // imgOriginal
            // 
            this.imgOriginal.Image = ((System.Drawing.Image)(resources.GetObject("imgOriginal.Image")));
            this.imgOriginal.Location = new System.Drawing.Point(12, 12);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(204, 203);
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            // 
            // imgCinza
            // 
            this.imgCinza.Location = new System.Drawing.Point(222, 12);
            this.imgCinza.Name = "imgCinza";
            this.imgCinza.Size = new System.Drawing.Size(204, 203);
            this.imgCinza.TabIndex = 1;
            this.imgCinza.TabStop = false;
            // 
            // btnEscCinza
            // 
            this.btnEscCinza.Location = new System.Drawing.Point(178, 231);
            this.btnEscCinza.Name = "btnEscCinza";
            this.btnEscCinza.Size = new System.Drawing.Size(75, 23);
            this.btnEscCinza.TabIndex = 2;
            this.btnEscCinza.Text = "Cinza";
            this.btnEscCinza.UseVisualStyleBackColor = true;
            this.btnEscCinza.Click += new System.EventHandler(this.btnEscCinza_Click);
            // 
            // btnLimiar
            // 
            this.btnLimiar.Location = new System.Drawing.Point(386, 231);
            this.btnLimiar.Name = "btnLimiar";
            this.btnLimiar.Size = new System.Drawing.Size(83, 23);
            this.btnLimiar.TabIndex = 3;
            this.btnLimiar.Text = "Limiarização";
            this.btnLimiar.UseVisualStyleBackColor = true;
            this.btnLimiar.Click += new System.EventHandler(this.btnLimiar_Click);
            // 
            // btnDilatar
            // 
            this.btnDilatar.Location = new System.Drawing.Point(582, 231);
            this.btnDilatar.Name = "btnDilatar";
            this.btnDilatar.Size = new System.Drawing.Size(110, 23);
            this.btnDilatar.TabIndex = 4;
            this.btnDilatar.Text = "Dilatar";
            this.btnDilatar.UseVisualStyleBackColor = true;
            this.btnDilatar.Click += new System.EventHandler(this.btnDilatar_Click);
            // 
            // imgLimiar
            // 
            this.imgLimiar.Location = new System.Drawing.Point(432, 12);
            this.imgLimiar.Name = "imgLimiar";
            this.imgLimiar.Size = new System.Drawing.Size(204, 203);
            this.imgLimiar.TabIndex = 5;
            this.imgLimiar.TabStop = false;
            // 
            // btnErodir
            // 
            this.btnErodir.Location = new System.Drawing.Point(799, 231);
            this.btnErodir.Name = "btnErodir";
            this.btnErodir.Size = new System.Drawing.Size(110, 23);
            this.btnErodir.TabIndex = 6;
            this.btnErodir.Text = "Erodir";
            this.btnErodir.UseVisualStyleBackColor = true;
            this.btnErodir.Click += new System.EventHandler(this.btnErodir_Click);
            // 
            // imgDilatada
            // 
            this.imgDilatada.Location = new System.Drawing.Point(642, 12);
            this.imgDilatada.Name = "imgDilatada";
            this.imgDilatada.Size = new System.Drawing.Size(204, 203);
            this.imgDilatada.TabIndex = 7;
            this.imgDilatada.TabStop = false;
            // 
            // imgErodida
            // 
            this.imgErodida.Location = new System.Drawing.Point(852, 12);
            this.imgErodida.Name = "imgErodida";
            this.imgErodida.Size = new System.Drawing.Size(204, 203);
            this.imgErodida.TabIndex = 8;
            this.imgErodida.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 287);
            this.Controls.Add(this.imgErodida);
            this.Controls.Add(this.imgDilatada);
            this.Controls.Add(this.btnErodir);
            this.Controls.Add(this.imgLimiar);
            this.Controls.Add(this.btnDilatar);
            this.Controls.Add(this.btnLimiar);
            this.Controls.Add(this.btnEscCinza);
            this.Controls.Add(this.imgCinza);
            this.Controls.Add(this.imgOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCinza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLimiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDilatada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgErodida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.PictureBox imgCinza;
        private System.Windows.Forms.Button btnEscCinza;
        private System.Windows.Forms.Button btnLimiar;
        private System.Windows.Forms.Button btnDilatar;
        private System.Windows.Forms.PictureBox imgLimiar;
        private System.Windows.Forms.Button btnErodir;
        private System.Windows.Forms.PictureBox imgDilatada;
        private System.Windows.Forms.PictureBox imgErodida;
    }
}

