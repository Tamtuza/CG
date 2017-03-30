namespace FiltragemApp2
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
            this.btnPassaAlta = new System.Windows.Forms.Button();
            this.imgoriginal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgoriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPassaAlta
            // 
            this.btnPassaAlta.Location = new System.Drawing.Point(374, 625);
            this.btnPassaAlta.Name = "btnPassaAlta";
            this.btnPassaAlta.Size = new System.Drawing.Size(75, 23);
            this.btnPassaAlta.TabIndex = 0;
            this.btnPassaAlta.Text = "Passa Alta Laplaciano";
            this.btnPassaAlta.UseVisualStyleBackColor = true;
            this.btnPassaAlta.Click += new System.EventHandler(this.btnPassaAlta_Click);
            // 
            // imgoriginal
            // 
            this.imgoriginal.Image = ((System.Drawing.Image)(resources.GetObject("imgoriginal.Image")));
            this.imgoriginal.Location = new System.Drawing.Point(12, 12);
            this.imgoriginal.Name = "imgoriginal";
            this.imgoriginal.Size = new System.Drawing.Size(804, 595);
            this.imgoriginal.TabIndex = 1;
            this.imgoriginal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 660);
            this.Controls.Add(this.imgoriginal);
            this.Controls.Add(this.btnPassaAlta);
            this.Name = "Form1";
            this.Text = "FiltragemApp2";
            ((System.ComponentModel.ISupportInitialize)(this.imgoriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassaAlta;
        private System.Windows.Forms.PictureBox imgoriginal;
    }
}

