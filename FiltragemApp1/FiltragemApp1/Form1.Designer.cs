namespace FiltragemApp1
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
            this.imgtulipas = new System.Windows.Forms.PictureBox();
            this.imgtulipasmod = new System.Windows.Forms.PictureBox();
            this.btnCor = new System.Windows.Forms.Button();
            this.btnEscurecer = new System.Windows.Forms.Button();
            this.btnBinarizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgtulipas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgtulipasmod)).BeginInit();
            this.SuspendLayout();
            // 
            // imgtulipas
            // 
            this.imgtulipas.Image = ((System.Drawing.Image)(resources.GetObject("imgtulipas.Image")));
            this.imgtulipas.Location = new System.Drawing.Point(13, 13);
            this.imgtulipas.Name = "imgtulipas";
            this.imgtulipas.Size = new System.Drawing.Size(520, 390);
            this.imgtulipas.TabIndex = 0;
            this.imgtulipas.TabStop = false;
            // 
            // imgtulipasmod
            // 
            this.imgtulipasmod.Location = new System.Drawing.Point(539, 13);
            this.imgtulipasmod.Name = "imgtulipasmod";
            this.imgtulipasmod.Size = new System.Drawing.Size(521, 390);
            this.imgtulipasmod.TabIndex = 1;
            this.imgtulipasmod.TabStop = false;
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(291, 429);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(75, 23);
            this.btnCor.TabIndex = 2;
            this.btnCor.Text = "Red/Blue";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnEscurecer
            // 
            this.btnEscurecer.Location = new System.Drawing.Point(498, 429);
            this.btnEscurecer.Name = "btnEscurecer";
            this.btnEscurecer.Size = new System.Drawing.Size(75, 23);
            this.btnEscurecer.TabIndex = 3;
            this.btnEscurecer.Text = "Escurecer";
            this.btnEscurecer.UseVisualStyleBackColor = true;
            this.btnEscurecer.Click += new System.EventHandler(this.btnEscurecer_Click);
            // 
            // btnBinarizar
            // 
            this.btnBinarizar.Location = new System.Drawing.Point(720, 429);
            this.btnBinarizar.Name = "btnBinarizar";
            this.btnBinarizar.Size = new System.Drawing.Size(75, 23);
            this.btnBinarizar.TabIndex = 4;
            this.btnBinarizar.Text = "Binarizar";
            this.btnBinarizar.UseVisualStyleBackColor = true;
            this.btnBinarizar.Click += new System.EventHandler(this.btnBinarizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 500);
            this.Controls.Add(this.btnBinarizar);
            this.Controls.Add(this.btnEscurecer);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.imgtulipasmod);
            this.Controls.Add(this.imgtulipas);
            this.Name = "Form1";
            this.Text = "FiltragemApp1";
            ((System.ComponentModel.ISupportInitialize)(this.imgtulipas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgtulipasmod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgtulipas;
        private System.Windows.Forms.PictureBox imgtulipasmod;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button btnEscurecer;
        private System.Windows.Forms.Button btnBinarizar;
    }
}

