namespace DesenhaFormas
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
            this.imgbranca = new System.Windows.Forms.PictureBox();
            this.btnRiscar = new System.Windows.Forms.Button();
            this.btnCruz = new System.Windows.Forms.Button();
            this.btnLinhas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgbranca)).BeginInit();
            this.SuspendLayout();
            // 
            // imgbranca
            // 
            this.imgbranca.Image = ((System.Drawing.Image)(resources.GetObject("imgbranca.Image")));
            this.imgbranca.InitialImage = null;
            this.imgbranca.Location = new System.Drawing.Point(27, 26);
            this.imgbranca.Name = "imgbranca";
            this.imgbranca.Size = new System.Drawing.Size(505, 407);
            this.imgbranca.TabIndex = 0;
            this.imgbranca.TabStop = false;
            this.imgbranca.Click += new System.EventHandler(this.imgbranca_Click);
            // 
            // btnRiscar
            // 
            this.btnRiscar.Location = new System.Drawing.Point(27, 461);
            this.btnRiscar.Name = "btnRiscar";
            this.btnRiscar.Size = new System.Drawing.Size(75, 23);
            this.btnRiscar.TabIndex = 1;
            this.btnRiscar.Text = "Riscar";
            this.btnRiscar.UseVisualStyleBackColor = true;
            this.btnRiscar.Click += new System.EventHandler(this.btnRiscar_Click);
            // 
            // btnCruz
            // 
            this.btnCruz.Location = new System.Drawing.Point(447, 461);
            this.btnCruz.Name = "btnCruz";
            this.btnCruz.Size = new System.Drawing.Size(75, 23);
            this.btnCruz.TabIndex = 2;
            this.btnCruz.Text = "Cruz";
            this.btnCruz.UseVisualStyleBackColor = true;
            this.btnCruz.Click += new System.EventHandler(this.btnCruz_Click);
            // 
            // btnLinhas
            // 
            this.btnLinhas.Location = new System.Drawing.Point(245, 461);
            this.btnLinhas.Name = "btnLinhas";
            this.btnLinhas.Size = new System.Drawing.Size(75, 23);
            this.btnLinhas.TabIndex = 3;
            this.btnLinhas.Text = "Linhas";
            this.btnLinhas.UseVisualStyleBackColor = true;
            this.btnLinhas.Click += new System.EventHandler(this.btnLinhas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 516);
            this.Controls.Add(this.btnLinhas);
            this.Controls.Add(this.btnCruz);
            this.Controls.Add(this.btnRiscar);
            this.Controls.Add(this.imgbranca);
            this.Name = "Form1";
            this.Text = "Desenha Formas";
            ((System.ComponentModel.ISupportInitialize)(this.imgbranca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgbranca;
        private System.Windows.Forms.Button btnRiscar;
        private System.Windows.Forms.Button btnCruz;
        private System.Windows.Forms.Button btnLinhas;
    }
}

