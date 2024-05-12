using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyGame
{
    internal class Enemy
    {
        private int enemySpeed = 3;
        private PictureBox enemy;
        private Panel gamePanel;
        private Random rand = new Random();

        public Enemy(PictureBox enemyPrototype, Panel gamePanel)
        {
            this.enemy = new PictureBox
            {
                Image = enemyPrototype.Image,
                SizeMode = enemyPrototype.SizeMode,
                Size = enemyPrototype.Size,
                Tag = "enemy"
            };
            this.gamePanel = gamePanel;
        }

        public void Generate()
        {
            if (rand.Next(100) < 5) // 2% chance to spawn an enemy each tick
            {
                PictureBox enemyClone = new PictureBox
                {
                    Image = enemy.Image,
                    SizeMode = enemy.SizeMode,
                    Size = enemy.Size,
                    Location = new Point(rand.Next(gamePanel.Width - enemy.Width), 0),
                    Tag = "enemy"
                };
                gamePanel.Controls.Add(enemyClone);
            }
        }

        public void MoveEnemies()
        {
            foreach (Control x in gamePanel.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    x.Top += enemySpeed;

                    // Remove enemy if it goes off screen
                    if (x.Top > gamePanel.Height)
                    {
                        gamePanel.Controls.Remove(x);
                    }
                }
            }
        }
    }
}
