using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShootGame.Classes
{
    using System.Media;

    public class SoundManager
    {
        // this is the media type variables for play sounds
        private SoundPlayer loadSound;
        private SoundPlayer shootSound;
        private SoundPlayer blockSound;
        private SoundPlayer scoreSound;
        private SoundPlayer bothGainaBullet;
        private SoundPlayer bothLoseAbullet;
        private SoundPlayer blockVsBlock;
        private SoundPlayer hexWin;
        private SoundPlayer roboWin;
        private SoundPlayer hexBullet;
        private SoundPlayer roboBullet;

        // specific sound file paths for game
        public SoundManager()
        {
            loadSound = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\load.wav");
            shootSound = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\shoot.wav");
            blockSound = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\block.wav");
            scoreSound = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\score.wav");
            bothGainaBullet = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\bothGainaBullet.wav");
            bothLoseAbullet = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\BothloseAbullet.wav");
            blockVsBlock = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\blockVsBlock.wav");
            hexWin = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\hexWin.wav");
            roboWin = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\roboWin.wav");
            hexBullet = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\hexBullet.wav");
            roboBullet = new SoundPlayer(@"E:\Cloudutvecklare_Azure_Jensen\Homework\ShootGame\Sounds\roboBullet.wav");
        }

        // Methods for playing sounds
        public void PlayLoadSound() => loadSound.Play();
        public void PlayShootSound() => shootSound.Play();
        public void PlayBlockSound() => blockSound.Play();
        public void PlayScoreSound() => scoreSound.Play();
        public void PlayGainBulletSound() => bothGainaBullet.Play();
        public void PlayLoseBulletSound() => bothLoseAbullet.Play();
        public void PlayBlockVsBlockSound() => blockVsBlock.Play();
        public void PlayHexWinSound() => hexWin.Play();
        public void PlayRoboWinSound() => roboWin.Play();
        public void PlayHexBulletSound() => hexBullet.Play();
        public void PlayRoboBulletSound() => roboBullet.Play();

    }



}
