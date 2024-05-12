using System.Numerics;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyGame
{
    public partial class Form1 : Form
    {
        private Enemy enemyManager;

        private Bullet bulletManager;

        private Player playerManager;

        private int playerSpeed = 5;
       // private int bulletSpeed = 2;
        //private int enemySpeed = 3;

        bool isMovingLeft = false;
        bool isMovingRight = false;
        bool isShooting = false;

       // private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            enemyManager = new Enemy(enemy, panel1);
            bulletManager = new Bullet(bullet, panel1);
            playerManager = new Player(player, panel1);
            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.KeyUp += new KeyEventHandler(OnKeyUp);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
      
                isMovingLeft = true;

            }
            else if (e.KeyCode == Keys.Right)
            {
              
                isMovingRight = true;
            }


            else if (e.KeyCode == Keys.Space)
            {
                bulletManager.Shot(player);                
            }

        }
        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                isMovingLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                isMovingRight = false;
            }
            else if (e.KeyCode == Keys.Space)
            {
                isShooting = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isMovingLeft)
            {
                player.Location = new Point(player.Location.X - playerSpeed, player.Location.Y);
            }
            else if (isMovingRight)
            {
                player.Location = new Point(player.Location.X + playerSpeed, player.Location.Y);
            }


            bulletManager.MoveBullet();
               
            enemyManager.Generate();

            enemyManager.MoveEnemies();

            playerManager.playerDamage(playerManager); 
            // Check for collisions
            foreach (Control x in panel1.Controls)
            {
                if (x is PictureBox && x != player)
                {
                    foreach (Control y in panel1.Controls)
                    {
                        if (y is PictureBox && y != player && y != x)
                        {
                            // If a bullet hits an enemy
                            if (x.Bounds.IntersectsWith(y.Bounds))
                            {
                                panel1.Controls.Remove(x);
                                panel1.Controls.Remove(y);
                                break;
                            }
                        }
                    }
                }
            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}