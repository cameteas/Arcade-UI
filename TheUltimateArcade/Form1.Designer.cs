namespace WindowsFormsApplication1
{
    partial class theUltimateArcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theUltimateArcade));
            this.snakeButton = new System.Windows.Forms.Button();
            this.pongButton = new System.Windows.Forms.Button();
            this.pacmanButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // snakeButton
            // 
            this.snakeButton.BackColor = System.Drawing.Color.White;
            this.snakeButton.Enabled = false;
            this.snakeButton.Location = new System.Drawing.Point(327, 280);
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.Size = new System.Drawing.Size(192, 40);
            this.snakeButton.TabIndex = 6;
            this.snakeButton.Text = "PLAY";
            this.snakeButton.UseVisualStyleBackColor = false;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            // 
            // pongButton
            // 
            this.pongButton.BackColor = System.Drawing.Color.White;
            this.pongButton.Enabled = false;
            this.pongButton.Location = new System.Drawing.Point(327, 280);
            this.pongButton.Name = "pongButton";
            this.pongButton.Size = new System.Drawing.Size(192, 40);
            this.pongButton.TabIndex = 7;
            this.pongButton.Text = "PLAY";
            this.pongButton.UseVisualStyleBackColor = false;
            this.pongButton.Click += new System.EventHandler(this.pongButton_Click);
            // 
            // pacmanButton
            // 
            this.pacmanButton.BackColor = System.Drawing.Color.White;
            this.pacmanButton.Enabled = false;
            this.pacmanButton.Location = new System.Drawing.Point(327, 280);
            this.pacmanButton.Name = "pacmanButton";
            this.pacmanButton.Size = new System.Drawing.Size(192, 40);
            this.pacmanButton.TabIndex = 8;
            this.pacmanButton.Text = "PLAY";
            this.pacmanButton.UseVisualStyleBackColor = false;
            this.pacmanButton.Click += new System.EventHandler(this.pacmanButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.pacman;
            this.pictureBox3.Location = new System.Drawing.Point(490, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 131);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.Pong_Screen;
            this.pictureBox2.Location = new System.Drawing.Point(290, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.snake;
            this.pictureBox1.Location = new System.Drawing.Point(190, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(369, 238);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(110, 39);
            this.title.TabIndex = 10;
            this.title.Text = "TITLE";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.description.Location = new System.Drawing.Point(49, 332);
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description.Size = new System.Drawing.Size(92, 19);
            this.description.TabIndex = 11;
            this.description.Text = "Description";
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // theUltimateArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pongButton);
            this.Controls.Add(this.snakeButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pacmanButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "theUltimateArcade";
            this.Text = "The Ultimate Arcade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.theUltimateArcade_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button pongButton;
        private System.Windows.Forms.Button pacmanButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
    }
}

