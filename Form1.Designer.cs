namespace PracticeShootGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnRestart = new Button();
            btnBlock = new Button();
            btnShoot = new Button();
            btnLoad = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlNav = new Panel();
            btnClose = new Button();
            imageList1 = new ImageList(components);
            picPlayer = new PictureBox();
            PicRobo = new PictureBox();
            lblHex = new Label();
            lblRobo = new Label();
            lblScoreHex = new Label();
            lblRound = new Label();
            lblScoreRobo = new Label();
            lblHexBulletCount = new Label();
            lblRoboBulletCount = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRobo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnRestart);
            panel1.Controls.Add(btnBlock);
            panel1.Controls.Add(btnShoot);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 2000);
            panel1.TabIndex = 0;
            // 
            // btnRestart
            // 
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Font = new Font("Nirmala UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = Color.FromArgb(0, 126, 246);
            btnRestart.Image = Properties.Resources.restart;
            btnRestart.Location = new Point(3, 1647);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(510, 350);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            btnRestart.Leave += btnRestart_Leave;
            // 
            // btnBlock
            // 
            btnBlock.FlatAppearance.BorderSize = 0;
            btnBlock.FlatStyle = FlatStyle.Flat;
            btnBlock.Font = new Font("Nirmala UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBlock.ForeColor = Color.FromArgb(0, 126, 246);
            btnBlock.Image = Properties.Resources._342Shield1;
            btnBlock.Location = new Point(7, 1245);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(500, 350);
            btnBlock.TabIndex = 1;
            btnBlock.Text = "Block";
            btnBlock.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBlock.UseVisualStyleBackColor = true;
            btnBlock.Click += btnBlock_Click;
            btnBlock.Leave += btnBlock_Leave;
            // 
            // btnShoot
            // 
            btnShoot.FlatAppearance.BorderSize = 0;
            btnShoot.FlatStyle = FlatStyle.Flat;
            btnShoot.Font = new Font("Nirmala UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShoot.ForeColor = Color.FromArgb(0, 126, 246);
            btnShoot.Image = Properties.Resources._342Shoot;
            btnShoot.Location = new Point(7, 889);
            btnShoot.Name = "btnShoot";
            btnShoot.Size = new Size(500, 350);
            btnShoot.TabIndex = 1;
            btnShoot.Text = "Shoot";
            btnShoot.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnShoot.UseVisualStyleBackColor = true;
            btnShoot.Click += btnShoot_Click;
            btnShoot.Leave += btnShoot_Leave;
            // 
            // btnLoad
            // 
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Nirmala UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.FromArgb(0, 126, 246);
            btnLoad.Image = Properties.Resources._340;
            btnLoad.Location = new Point(7, 533);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(500, 350);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            btnLoad.Leave += btnLoad_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(510, 538);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User1;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 478);
            label2.Name = "label2";
            label2.Size = new Size(485, 46);
            label2.TabIndex = 2;
            label2.Text = "Player Name: HexHunter";
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);
            pnlNav.Location = new Point(0, 544);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(10, 2000);
            pnlNav.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.CloseButton;
            btnClose.Location = new Point(2903, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 85);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // picPlayer
            // 
            picPlayer.Image = Properties.Resources.Player;
            picPlayer.Location = new Point(705, 478);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(526, 972);
            picPlayer.SizeMode = PictureBoxSizeMode.AutoSize;
            picPlayer.TabIndex = 3;
            picPlayer.TabStop = false;
            // 
            // PicRobo
            // 
            PicRobo.Image = Properties.Resources.opponent;
            PicRobo.Location = new Point(2090, 478);
            PicRobo.Name = "PicRobo";
            PicRobo.Size = new Size(499, 976);
            PicRobo.SizeMode = PictureBoxSizeMode.AutoSize;
            PicRobo.TabIndex = 3;
            PicRobo.TabStop = false;
            // 
            // lblHex
            // 
            lblHex.AutoSize = true;
            lblHex.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold);
            lblHex.ForeColor = Color.FromArgb(50, 226, 178);
            lblHex.Location = new Point(798, 421);
            lblHex.Name = "lblHex";
            lblHex.Size = new Size(257, 54);
            lblHex.TabIndex = 4;
            lblHex.Text = "HexHunter";
            // 
            // lblRobo
            // 
            lblRobo.AutoSize = true;
            lblRobo.Font = new Font("Microsoft Sans Serif", 14.1F, FontStyle.Bold);
            lblRobo.ForeColor = Color.FromArgb(50, 226, 178);
            lblRobo.Location = new Point(2191, 389);
            lblRobo.Name = "lblRobo";
            lblRobo.Size = new Size(302, 54);
            lblRobo.TabIndex = 4;
            lblRobo.Text = "RoboGunner";
            // 
            // lblScoreHex
            // 
            lblScoreHex.AutoSize = true;
            lblScoreHex.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreHex.ForeColor = SystemColors.ControlLightLight;
            lblScoreHex.Location = new Point(705, 254);
            lblScoreHex.Name = "lblScoreHex";
            lblScoreHex.Size = new Size(416, 62);
            lblScoreHex.TabIndex = 4;
            lblScoreHex.Text = "HexHunter Score:";
            lblScoreHex.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold);
            lblRound.ForeColor = SystemColors.ControlLightLight;
            lblRound.Location = new Point(1607, 1488);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(224, 62);
            lblRound.TabIndex = 4;
            lblRound.Text = "Round: 3";
            lblRound.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreRobo
            // 
            lblScoreRobo.AutoSize = true;
            lblScoreRobo.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreRobo.ForeColor = SystemColors.ControlLightLight;
            lblScoreRobo.Location = new Point(2090, 254);
            lblScoreRobo.Name = "lblScoreRobo";
            lblScoreRobo.Size = new Size(453, 62);
            lblScoreRobo.TabIndex = 5;
            lblScoreRobo.Text = "RoboGunner Score:";
            // 
            // lblHexBulletCount
            // 
            lblHexBulletCount.AutoSize = true;
            lblHexBulletCount.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold);
            lblHexBulletCount.ForeColor = SystemColors.ControlLightLight;
            lblHexBulletCount.Location = new Point(705, 1488);
            lblHexBulletCount.Name = "lblHexBulletCount";
            lblHexBulletCount.Size = new Size(566, 62);
            lblHexBulletCount.TabIndex = 6;
            lblHexBulletCount.Text = "HexHunter Bullet Count:";
            // 
            // lblRoboBulletCount
            // 
            lblRoboBulletCount.AutoSize = true;
            lblRoboBulletCount.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold);
            lblRoboBulletCount.ForeColor = SystemColors.ControlLightLight;
            lblRoboBulletCount.Location = new Point(2090, 1488);
            lblRoboBulletCount.Name = "lblRoboBulletCount";
            lblRoboBulletCount.Size = new Size(603, 62);
            lblRoboBulletCount.TabIndex = 7;
            lblRoboBulletCount.Text = "RoboGunner Bullet Count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(3000, 2000);
            Controls.Add(lblRoboBulletCount);
            Controls.Add(lblHexBulletCount);
            Controls.Add(lblScoreRobo);
            Controls.Add(lblRound);
            Controls.Add(lblScoreHex);
            Controls.Add(lblRobo);
            Controls.Add(lblHex);
            Controls.Add(PicRobo);
            Controls.Add(picPlayer);
            Controls.Add(btnClose);
            Controls.Add(pnlNav);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shadow Shotgun";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRobo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLoad;
        private Button btnRestart;
        private Button btnBlock;
        private Button btnShoot;
        public Panel pnlNav;
        private Button btnClose;
        private ImageList imageList1;
        private PictureBox picPlayer;
        private PictureBox PicRobo;
        public Label lblHex;
        public Label lblRobo;
        public Label lblScoreHex;
        public Label lblRound;
        public Label lblScoreRobo;
        public Label lblHexBulletCount;
        public Label lblRoboBulletCount;
    }
}
