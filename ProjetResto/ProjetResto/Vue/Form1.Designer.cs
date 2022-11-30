namespace ProjetResto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Carré1 = new System.Windows.Forms.PictureBox();
            this.Carré2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Accueil = new System.Windows.Forms.PictureBox();
            this.mh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Carré1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carré2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accueil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mh)).BeginInit();
            this.SuspendLayout();
            // 
            // Carré1
            // 
            this.Carré1.Image = ((System.Drawing.Image)(resources.GetObject("Carré1.Image")));
            this.Carré1.Location = new System.Drawing.Point(23, 27);
            this.Carré1.Name = "Carré1";
            this.Carré1.Size = new System.Drawing.Size(515, 326);
            this.Carré1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Carré1.TabIndex = 0;
            this.Carré1.TabStop = false;
            // 
            // Carré2
            // 
            this.Carré2.Image = ((System.Drawing.Image)(resources.GetObject("Carré2.Image")));
            this.Carré2.Location = new System.Drawing.Point(534, 27);
            this.Carré2.Name = "Carré2";
            this.Carré2.Size = new System.Drawing.Size(445, 326);
            this.Carré2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Carré2.TabIndex = 1;
            this.Carré2.TabStop = false;
            this.Carré2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "SALLE DE RESTAURATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 349);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(351, 331);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(149, 683);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUISINE";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Accueil
            // 
            this.Accueil.Image = ((System.Drawing.Image)(resources.GetObject("Accueil.Image")));
            this.Accueil.Location = new System.Drawing.Point(979, 27);
            this.Accueil.Name = "Accueil";
            this.Accueil.Size = new System.Drawing.Size(196, 327);
            this.Accueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Accueil.TabIndex = 4;
            this.Accueil.TabStop = false;
            this.Accueil.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mh
            // 
            this.mh.Image = ((System.Drawing.Image)(resources.GetObject("mh.Image")));
            this.mh.Location = new System.Drawing.Point(1038, 47);
            this.mh.Name = "mh";
            this.mh.Size = new System.Drawing.Size(17, 15);
            this.mh.TabIndex = 5;
            this.mh.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1239, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mh);
            this.Controls.Add(this.Accueil);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Carré2);
            this.Controls.Add(this.Carré1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "SALLE DE RESTAURATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Carré1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Carré2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accueil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Carré1;
        private System.Windows.Forms.PictureBox Carré2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Accueil;
        private System.Windows.Forms.PictureBox mh;
    }
}

