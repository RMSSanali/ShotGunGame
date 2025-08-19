using Microsoft.VisualBasic.Devices;
using PracticeShootGame.Classes;
using System;
using System.Media;
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PracticeShootGame
{
    public partial class Form1 : Form
    {
        //initiate classes
        private Game game;
        private SoundManager soundManager;
        private UIManager uiManager;

        public Form1() 
        {
            InitializeComponent();
            soundManager = new SoundManager(); // Initialize SoundManager first
            game = new Game(); // Pass SoundManager to Game
            uiManager = new UIManager(this);

            
            SetupGame();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (game.GameOver)
            {
                return;
            }
            else
            {

                uiManager.SetNavButtonStyles(btnLoad);
                this.InitiatePlayerChoice("Load", Properties.Resources.PlayerLoading);
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            if (game.GameOver || game.PlayerBullets <= 0)
            {
                return;
            }
            else
            {

                uiManager.SetNavButtonStyles(btnShoot);
                InitiatePlayerChoice("Shoot", Properties.Resources.PlayerShoot);
            }
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (game.GameOver)
            {
                return;
            }
            else
            {

                uiManager.SetNavButtonStyles(btnBlock);
                InitiatePlayerChoice("Block", Properties.Resources.PlayerShielding);
            }
        }
        private void btnRestart_Click(object sender, EventArgs e) => ResetGame();

        private void ResetGame()
        {
            game.ResetGame(picPlayer, PicRobo);
            uiManager.UpdateGameStateDisplay(game);
        }

        private void btnLoad_Leave(object sender, EventArgs e)
        {
            btnLoad.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnShoot_Leave(object sender, EventArgs e)
        {
            btnShoot.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBlock_Leave(object sender, EventArgs e)
        {
            btnBlock.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRestart_Leave(object sender, EventArgs e)
        {
            btnRestart.BackColor = Color.FromArgb(24, 30, 54);
        }

        // Method to handle the Close button click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        // methods area

        private void SetupGame()
        {
            uiManager.UpdateGameStateDisplay(game);
            game.GameOver = false;
            lblRound.Text = "Round: 0";
        }

        private void InitiatePlayerChoice(string choice, Image playerImage)
        {
            if (game.GameOver) 
            {
                return;
            }
            else
            {

                picPlayer.Image = playerImage;
                game.ExecutePlayerChoice(choice, picPlayer, PicRobo);
                uiManager.UpdateGameStateDisplay(game);

                if (game.CheckGameOver())
                {
                    MessageBox.Show(game.GetWinningMessage(picPlayer, PicRobo), "Game Over");
                }
            }


        }
    }
}
