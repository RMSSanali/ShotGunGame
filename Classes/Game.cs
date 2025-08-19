using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeShootGame.Classes
{
    public class Game
    {
        // game class varibles
        public int PlayerBullets { get; set; }
        public int ComputerBullets { get; set; }
        public int PlayerScore { get; set; }
        public int RoboScore { get; set; }
        public bool GameOver { get; set; }

        private Random rand = new Random();  // create object in random class.
        private SoundManager soundManager = new SoundManager();
        
        public Game()  // constructor in the game class
        {
            PlayerBullets = 0;
            ComputerBullets = 0;
            PlayerScore = 0;
            RoboScore = 0;
            GameOver = false;
        }

        public string GetComputerAction()
        {
            if (ComputerBullets <= 0)
            {
                return rand.Next(2) == 0 ? "Load" : "Block";
            }
            return new string[] { "Load", "Shoot", "Block" }[rand.Next(3)]; // get strings for chose computer actions
        }

        //this method handle play and computer's,  score and bullet based on the choice
        public void UpdateScoresAndBullets(string playerChoice, string computerChoice)
        {
            if (playerChoice == "Load" && computerChoice == "Load")
            {
                if (PlayerBullets < 3) PlayerBullets++;
                if (ComputerBullets < 3) ComputerBullets++;
            }
            else if (playerChoice == "Load" && computerChoice == "Block")
            {
                if (PlayerBullets < 3) PlayerBullets++;
            }
            else if (playerChoice == "Block" && computerChoice == "Block")
            {
                // Nothing happens

            }
            else if (playerChoice == "Shoot" && computerChoice == "Block")
            {
                if (PlayerBullets > 0)
                {
                    PlayerBullets--;
                }
            }
            else if (playerChoice == "Shoot" && computerChoice == "Shoot")
            {
                if (PlayerBullets > 0 && ComputerBullets > 0)
                {
                    PlayerBullets--;
                    ComputerBullets--;
                }
            }
            else if (playerChoice == "Shoot" && computerChoice == "Load")
            {
                if (PlayerBullets > 0)
                {
                    PlayerBullets--;
                    PlayerScore++;
                }
            }
            else if (playerChoice == "Load" && computerChoice == "Shoot")
            {
                if (ComputerBullets > 0)
                {
                    ComputerBullets--;
                    RoboScore++;
                }
            }
            else if (playerChoice == "Block" && computerChoice == "Load")
            {
                if (ComputerBullets < 3) ComputerBullets++;
            }
            else if (playerChoice == "Block" && computerChoice == "Shoot")
            {
                if (ComputerBullets > 0)
                {
                    ComputerBullets--;
                }
            }
            else if (playerChoice == "Shoot" && computerChoice == "Block")
            {
                if (PlayerBullets > 0)
                {
                    PlayerBullets--;
                }
            }
        }

        public bool CheckGameOver() // check the number of bullets and we can decide game over or not 
        {
            if (PlayerBullets >= 3 || ComputerBullets >= 3)
            {
                GameOver = true;
                return true;
            }
            return false;
        }

        public string GetWinningMessage(PictureBox picPlayer, PictureBox picRobo) //picture parameter called here
        {


            if (PlayerBullets >= 3)
            {
                picPlayer.Image = Properties.Resources.hexHunterWin;
                return "HexHunter wins with enough bullets for SHOTGUN!";
            }
            else if (ComputerBullets >= 3)
            {
                picPlayer.Image = Properties.Resources.roboGunnerWin;
                return "RoboGunner wins with enough bullets for SHOTGUN!";
            }
            return "";
        }

        public void ExecutePlayerChoice(string playerChoice, PictureBox picPlayer, PictureBox picRobo)  
        {
            if (GameOver)
            {
                return; 
            }
            else
            {
                string computerChoice = GetComputerAction(); // call this method and get computer random choice
                UpdateRoboImage(computerChoice, picRobo);
                UpdateScoresAndBullets(playerChoice, computerChoice);
                PlayGameSounds(playerChoice, computerChoice);

            }         
        }

        public void ResetGame(PictureBox picPlayer, PictureBox picRobo)
        {
            // Reset all variables for start new game
            PlayerBullets = 0;
            ComputerBullets = 0;
            PlayerScore = 0;
            RoboScore = 0;
            GameOver = false;

            // Reset players images
            picPlayer.Image = Properties.Resources.Player;
            picRobo.Image = Properties.Resources.opponent;
        }

        public void PlayGameSounds(string PlayerChoice, string RoboChoice)
        {
            if (PlayerChoice == "Load" && RoboChoice == "Load")
            {
                soundManager.PlayLoadSound();
                soundManager.PlayGainBulletSound();
                MessageBox.Show("Both load! Each gains a bullet.");
            }
            else if (PlayerChoice == "Load" && RoboChoice == "Block")
            {
                soundManager.PlayLoadSound();
                soundManager.PlayHexBulletSound();
                MessageBox.Show("HexHunter loads a bullet while RoboGunner takes cover.");
            }
            else if (PlayerChoice == "Block" && RoboChoice == "Block")
            {
                soundManager.PlayBlockSound();
                soundManager.PlayBlockVsBlockSound();
                MessageBox.Show("Both block, no action taken.");
            }
            else if (PlayerChoice == "Shoot" && RoboChoice == "Block")
            {
                if (PlayerBullets > 0)
                {
                    soundManager.PlayShootSound();
                    MessageBox.Show("RoboGunner blocks! HexHunter’s bullet is wasted.");
                }
                else
                {
                    MessageBox.Show("No bullets left for HexHunter. Load again");
                }
            }
            else if (PlayerChoice == "Shoot" && RoboChoice == "Shoot")
            {
                if (PlayerBullets > 0 && ComputerBullets > 0)
                {
                    soundManager.PlayShootSound();
                    soundManager.PlayLoseBulletSound();
                    MessageBox.Show("Both shoot! Each loses a bullet.");
                }
                else
                {
                    MessageBox.Show("Click! One or both players are out of bullets. please reset game");
                }
            }
            else if (PlayerChoice == "Shoot" && RoboChoice == "Load")
            {
                if (PlayerBullets > 0)
                {
                    soundManager.PlayShootSound();
                    PlayerScore++;
                    MessageBox.Show("HexHunter shoots while RoboGunner loads! HexHunter scores.");
                    soundManager.PlayScoreSound();
                }
                else
                {
                    MessageBox.Show("No bullets left for HexHunter.");
                }
            }
            else if (PlayerChoice == "Load" && RoboChoice == "Shoot")
            {
                if (ComputerBullets > 0)
                {
                    soundManager.PlayLoadSound();
                    RoboScore++;
                    soundManager.PlayScoreSound();
                    MessageBox.Show("RoboGunner shoots while HexHunter loads! RoboGunner scores.");
                }
                else
                {
                    MessageBox.Show("No bullets left for RoboGunner.");
                }
            }
            else if (PlayerChoice == "Block" && RoboChoice == "Load")
            {
                soundManager.PlayBlockSound();
                soundManager.PlayRoboBulletSound();
                MessageBox.Show("HexHunter blocks while RoboGunner loads a bullet.");
            }
            else if (PlayerChoice == "Block" && RoboChoice == "Shoot")
            {
                if (ComputerBullets > 0)
                {
                    soundManager.PlayBlockSound();
                    MessageBox.Show("HexHunter successfully blocks RoboGunner's shot!");
                }
                else
                {
                    MessageBox.Show("RoboGunner attempted to shoot, but has no bullets left.");
                }
            }
            else if (PlayerChoice == "Shoot" && RoboChoice == "Block")
            {
                if (PlayerBullets > 0)
                {
                    soundManager.PlayShootSound();
                    MessageBox.Show("HexHunter's shot is blocked by RoboGunner!");
                }
                else
                {
                    MessageBox.Show("HexHunter attempted to shoot, but has no bullets left.");
                }
            }
        }

        public void UpdateRoboImage(string computerChoice, PictureBox picRobo)
        {
            if (computerChoice == "Load")
            {
                picRobo.Image = Properties.Resources.opponentLoading___left;
            }
            else if (computerChoice == "Shoot")
            {
                picRobo.Image = Properties.Resources.OpponentShootingLeft;
            }
            else if (computerChoice == "Block")
            {
                picRobo.Image = Properties.Resources.OpponentShieldingLeft;
            }
        }

    }
}




