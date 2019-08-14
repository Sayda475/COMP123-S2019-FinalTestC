namespace COMP123_S2019_FinalTestC.Views
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SplpictureBox = new System.Windows.Forms.PictureBox();
            this.Splashtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(247, 179);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(217, 24);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name: Sayda Rahman";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(247, 220);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(151, 24);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "#ID: 301042327";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_FinalTestC.Properties.Resources.logoC;
            this.pictureBox1.Location = new System.Drawing.Point(571, 463);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SplpictureBox
            // 
            this.SplpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SplpictureBox.Image = global::COMP123_S2019_FinalTestC.Properties.Resources.logo;
            this.SplpictureBox.Location = new System.Drawing.Point(60, 15);
            this.SplpictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.SplpictureBox.Name = "SplpictureBox";
            this.SplpictureBox.Size = new System.Drawing.Size(579, 110);
            this.SplpictureBox.TabIndex = 0;
            this.SplpictureBox.TabStop = false;
            this.SplpictureBox.Click += new System.EventHandler(this.SplashScreen_Load);
            // 
            // Splashtimer
            // 
            this.Splashtimer.Interval = 3000;
            this.Splashtimer.Tick += new System.EventHandler(this.Splashtimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SplpictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SplpictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Splashtimer;
    }
}