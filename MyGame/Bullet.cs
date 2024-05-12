using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyGame
{
    internal class Bullet
    {
        private int bulletSpeed = 2;
        private PictureBox bullet;
        private Panel gamePanel;

     //   PictureBox player = new PictureBox { };

        public Bullet(PictureBox bulletptoyotype, Panel gamePanel)
        {
            this.bullet = new PictureBox
            {
                Image = bulletptoyotype.Image,
                SizeMode = bulletptoyotype.SizeMode,
                Size = bulletptoyotype.Size,
                Tag = "bullet"
            };
            this.gamePanel = gamePanel;
        }

        public void Shot(PictureBox player)
        {
            PictureBox bullet1 = new PictureBox
            {
                Image = bullet.Image,
                SizeMode = bullet.SizeMode,
                Size = bullet.Size,
                Location = new Point(player.Location.X + player.Width / 2, player.Location.Y)
            };
            bullet1.Tag = "bullet";
            gamePanel.Controls.Add(bullet1);
            bullet1.Location = new Point(bullet1.Location.X, bullet1.Location.Y - bulletSpeed);
        }

        public void MoveBullet()
        {            
            foreach (Control x in gamePanel.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= bulletSpeed;

                    // Remove bullet if it goes off screen
                    if (x.Top < 0)
                    {
                        gamePanel.Controls.Remove(x);
                    }
                }
            }
        }
    }
}
