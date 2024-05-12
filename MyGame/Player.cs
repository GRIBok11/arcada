using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Player
    {

        private int playerSpeed = 5;
    private int playerHP = 3;
        PictureBox player = new PictureBox { };

        private Panel gamePanel;

        public Player(PictureBox playerPrototype, Panel gamePanel)
        {
            this.player = new PictureBox
            {
                Image = playerPrototype.Image,
                SizeMode = playerPrototype.SizeMode,
                Size = playerPrototype.Size,
                Tag = "player"
            };
            this.gamePanel = gamePanel;
        }

        public void Moveleft()
        {
            player.Location = new Point(player.Location.X - playerSpeed, player.Location.Y);
        }

        public void Moveright()
        {
            player.Location = new Point(player.Location.X + playerSpeed, player.Location.Y);
        }

        public void playerDamage(Player player)
        {
            foreach (Control x in gamePanel.Controls)
            {
                if (x is PictureBox && x.Tag == "enemy")
                {
                    // Проверяем, коснулся ли враг нижней границы панели
                    if (x.Bottom > gamePanel.Height)
                    {
                        player.playerHP -= 1; // Отнимаем здоровье у игрока
                        gamePanel.Controls.Remove(x); // Удаляем врага с панели
                        x.Dispose(); // Освобождаем ресурсы
                    }

                    // Проверяем, коснулся ли враг игрока
                    if (player.player.Bounds.IntersectsWith(x.Bounds))
                    {
                        player.playerHP -= 1; // Отнимаем здоровье у игрока
                        gamePanel.Controls.Remove(x); // Удаляем врага с панели
                        x.Dispose(); // Освобождаем ресурсы
                    }
                    if(player.playerHP ==0)
                    {
                        MessageBox.Show("Игра окончена! Вы проиграли.", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
