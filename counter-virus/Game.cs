using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace counter_virus
{
    public partial class Game : Form
    {
        // variable
        bool goUp, goDown, goLeft, goRight, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int virusSpeed = 3;
        Random random = new Random();

        List<PictureBox> virusList = new List<PictureBox>();

        public Game()
        {
            InitializeComponent();
            RestartGame();
        }

        // i misclicked the one from design; can't delete this since it will error
        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void MainTimer(object sender, EventArgs e)
        {
            // this is for the player's health
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth; // label of health
                healthBar.ForeColor = Color.Red;
            }

            // this is when the player hits 0 health
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.player_dead; // will display dead player image
                player.SizeMode = PictureBoxSizeMode.StretchImage;
                player.Size = new Size(110, 92);
                gameTimer.Stop();
            }

            // the label above game (ammmo and kills)
            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            // speed of player and also the boundaries of where it can go
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            // player getting the ammo
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5; // +5 everytime they intersect
                    }
                }

                // this is where the virus will follow the player
                if (x is PictureBox && (string)x.Tag == "virus")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1; // -1 everytime the virus touch the player
                    }

                    // virus following the player
                    if (x.Left > player.Left)
                    {
                        x.Left -= virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.virus;
                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.virus;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.virus;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.virus;
                    }
                }

                // this is where the bullet touch the virus
                foreach (Control j in this.Controls)
                {
                    if (x is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "virus")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            virusList.Remove((PictureBox)x);
                            MakeVirus();
                        }
                    }
                }
            }
        }

        // when the player is pressing the certain keys
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return; // so the key won't function when it's gameover
            }

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.player_left;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.player_right;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.player_up;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.player_down;
            }
        }

        // when the certain keys are not pressed down
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            // the gameover here means can't function the space bar when its gameover
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            // pressing enter means restarting game when its gameover
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        // method for shooring bullet
        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        // method for making virus
        private void MakeVirus()
        {
            PictureBox virus = new PictureBox();
            virus.Tag = "virus";
            virus.Image = Properties.Resources.virus;
            virus.SizeMode = PictureBoxSizeMode.StretchImage;
            virus.Size = new Size(60, 60);
            virus.Left = random.Next(0, 900);
            virus.Top = random.Next(0, 800);
            virus.SizeMode = PictureBoxSizeMode.StretchImage;
            virusList.Add(virus);
            this.Controls.Add(virus);
            player.BringToFront();
        }

        // method for dropping ammo
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Tag = "ammo";
            ammo.Image = Properties.Resources.essentials_food;
            ammo.SizeMode = PictureBoxSizeMode.StretchImage;
            ammo.Size = new Size(60, 45);
            ammo.Left = random.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = random.Next(60, this.ClientSize.Height - ammo.Height);
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        }

        // emthod for restarting game
        private void RestartGame()
        {
            player.Image = Properties.Resources.player_up; // default position of player
            
            // will turn back to its default settings
            foreach (PictureBox vl in virusList)
            {
                this.Controls.Remove(vl);
            }

            virusList.Clear();

            for (int vl = 0; vl < 3; vl++)
            {
                MakeVirus();
            }

            goUp = false;
            goDown = false;
            goRight = false;
            goLeft = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;
            player.Size = new Size(95, 77); // so the player size wont copy the player_dead's size

            gameTimer.Start();
        }
    }
}
