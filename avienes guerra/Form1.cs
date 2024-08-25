using avienes_guerra.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avienes_guerra
{
    public partial class Form1 : Form
    {
        
        bool goLeft, goRight, shooting, isGamerOver;
        int score;
        int playerSpeed = 7;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            resetGame();
        }
        private void reproducir()
        {
            
        }
        private void mainGamerTimerEvents(object sender, EventArgs e)
        {

            txtscore.Text = score.ToString();

            enemyone.Top += enemySpeed;
            enemytwo.Top += enemySpeed;
            enemytre.Top += enemySpeed;


            if (enemyone.Top > 710 || enemytwo.Top > 710 || enemytre.Top >710)
            {
                gameOver();
            }

            // player movimiento 

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Right < 665)
            {
                player.Left += playerSpeed;
            }

            // bala movimiento

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyone.Bounds)) 
            {
                score += 1;
                enemyone.Top = -450;
                enemyone.Left = rnd.Next(0, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemytwo.Bounds)) 
            {
                score += 1;
                enemytwo.Top = -650;
                enemytwo.Left = rnd.Next(0, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemytre.Bounds)) 
            {
                score += 1;
                enemytre.Top = -750;
                enemytre.Left = rnd.Next(0, 600);
                shooting = false;
            }

            if (score == 5)
            {
                enemySpeed = 10;
                playerSpeed = 10;
            }
            if (score == 15)
            {
                enemySpeed = 15;
                playerSpeed = 15;
            }
            if (score == 20)
            {
                enemySpeed = 20;
                playerSpeed = 25;
            }
            if (score == 30)
            {
                enemySpeed = 25;
                playerSpeed = 35;
            }
            if (score == 40)
            {
                enemySpeed = 35;
                playerSpeed = 45;
            }
            if (score == 50)
            {
                enemySpeed = 15;
                playerSpeed = 75;
            }
        }

        private void KeyisDowm(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);
            }
            if (e.KeyCode == Keys.Enter && isGamerOver == true)
            {
                resetGame();
            }
        }
        private void resetGame()
        {
            gamerTimer.Start();
            enemySpeed = 6;

            enemyone.Left = rnd.Next(0, 600);
            enemytwo.Left = rnd.Next(0, 600);
            enemytre.Left = rnd.Next(0, 600);

            enemyone.Top = rnd.Next(0, 200) * -1;
            enemytwo.Top = rnd.Next(0, 500) * -1;
            enemytre.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;

            txtscore.Text = score.ToString();
        }
        private void gameOver()
        {
            isGamerOver = true;
            gamerTimer.Stop();
            txtscore.Text += Environment.NewLine + "fin del juego" + Environment.NewLine + "presiona enter para volver a intentar";
        }
    }
}
