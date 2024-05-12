namespace MyGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            enemy = new PictureBox();
            player = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bullet = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)enemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(enemy);
            panel1.Controls.Add(player);
            panel1.Location = new Point(20, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 684);
            panel1.TabIndex = 0;
            // 
            // enemy
            // 
            enemy.Image = (Image)resources.GetObject("enemy.Image");
            enemy.Location = new Point(203, 53);
            enemy.Name = "enemy";
            enemy.Size = new Size(69, 52);
            enemy.SizeMode = PictureBoxSizeMode.CenterImage;
            enemy.TabIndex = 1;
            enemy.TabStop = false;
            // 
            // player
            // 
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(150, 619);
            player.Name = "player";
            player.Size = new Size(122, 62);
            player.SizeMode = PictureBoxSizeMode.CenterImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // bullet
            // 
            bullet.Image = (Image)resources.GetObject("bullet.Image");
            bullet.Location = new Point(3, 356);
            bullet.Name = "bullet";
            bullet.Size = new Size(10, 10);
            bullet.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet.TabIndex = 1;
            bullet.TabStop = false;
            bullet.Visible = false;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 762);
            Controls.Add(bullet);
            Controls.Add(panel1);
            DoubleBuffered = true;
            KeyPreview = true;
            Name = "Form1";
            Text = " ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)enemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)bullet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bullet;
        private PictureBox enemy;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}