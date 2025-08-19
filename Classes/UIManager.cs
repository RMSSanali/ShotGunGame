using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShootGame.Classes
{
    internal class UIManager
    {
        private Form1 form;

    public UIManager(Form1 form)
    {
        this.form = form;
    }

        // update fame diapaly counds and sccores
    public void UpdateGameStateDisplay(Game game)
    {
        form.lblHexBulletCount.Text = "HexHunter Bullet Count: " + game.PlayerBullets;
        form.lblRoboBulletCount.Text = "RoboGunner Bullet Count: " + game.ComputerBullets;
        form.lblScoreHex.Text = "HexHunter Score: " + game.PlayerScore;
        form.lblScoreRobo.Text = "RoboGunner Score: " + game.RoboScore;
        form.lblRound.Text = "Round: " + game.RoboScore;  // Assuming there's a round count
    }

    public void SetNavButtonStyles(Button button)
    {
        form.pnlNav.Height = button.Height;
        form.pnlNav.Top = button.Top;
        form.pnlNav.Left = button.Left;
        button.BackColor = Color.FromArgb(46, 51, 73);
    }
    }
}
