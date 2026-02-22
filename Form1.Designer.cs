namespace Google_Dino_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            DinoPic = new PictureBox();
            Scoretxt = new Label();
            GameOvertxt = new Label();
            Restarttxt = new Label();
            JumpTimer = new System.Windows.Forms.Timer(components);
            CactusPic = new PictureBox();
            BirdPic = new PictureBox();
            ScoreNumtxt = new Label();
            TopScoretxt = new Label();
            TopScoreNumtxt = new Label();
            DecorativeDinoPic = new PictureBox();
            Hinttxt = new Label();
            ((System.ComponentModel.ISupportInitialize)DinoPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CactusPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirdPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DecorativeDinoPic).BeginInit();
            SuspendLayout();
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Interval = 1;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Location = new Point(-7, 367);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(987, 8);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Location = new Point(-7, 373);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(987, 79);
            label2.TabIndex = 0;
            // 
            // DinoPic
            // 
            DinoPic.Image = Properties.Resources.normal_running;
            DinoPic.Location = new Point(183, 317);
            DinoPic.Margin = new Padding(0);
            DinoPic.Name = "DinoPic";
            DinoPic.Size = new Size(50, 50);
            DinoPic.SizeMode = PictureBoxSizeMode.AutoSize;
            DinoPic.TabIndex = 1;
            DinoPic.TabStop = false;
            // 
            // Scoretxt
            // 
            Scoretxt.AutoSize = true;
            Scoretxt.BackColor = SystemColors.Control;
            Scoretxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Scoretxt.Location = new Point(9, 9);
            Scoretxt.Margin = new Padding(0);
            Scoretxt.Name = "Scoretxt";
            Scoretxt.Size = new Size(70, 28);
            Scoretxt.TabIndex = 2;
            Scoretxt.Text = "Score :";
            // 
            // GameOvertxt
            // 
            GameOvertxt.AutoSize = true;
            GameOvertxt.BackColor = SystemColors.Control;
            GameOvertxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GameOvertxt.Location = new Point(428, 103);
            GameOvertxt.Margin = new Padding(0);
            GameOvertxt.Name = "GameOvertxt";
            GameOvertxt.Size = new Size(117, 28);
            GameOvertxt.TabIndex = 2;
            GameOvertxt.Tag = "";
            GameOvertxt.Text = "Game Over";
            GameOvertxt.Visible = false;
            // 
            // Restarttxt
            // 
            Restarttxt.AutoSize = true;
            Restarttxt.BackColor = SystemColors.Control;
            Restarttxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Restarttxt.Location = new Point(375, 162);
            Restarttxt.Margin = new Padding(0);
            Restarttxt.Name = "Restarttxt";
            Restarttxt.Size = new Size(222, 28);
            Restarttxt.TabIndex = 2;
            Restarttxt.Tag = "";
            Restarttxt.Text = "Press Any Key To Restart";
            Restarttxt.Visible = false;
            // 
            // JumpTimer
            // 
            JumpTimer.Interval = 1;
            JumpTimer.Tick += JumpTimer_Tick;
            // 
            // CactusPic
            // 
            CactusPic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CactusPic.BackgroundImageLayout = ImageLayout.None;
            CactusPic.Image = Properties.Resources._6;
            CactusPic.Location = new Point(2000, 334);
            CactusPic.Margin = new Padding(0);
            CactusPic.Name = "CactusPic";
            CactusPic.Size = new Size(32, 33);
            CactusPic.SizeMode = PictureBoxSizeMode.AutoSize;
            CactusPic.TabIndex = 1;
            CactusPic.TabStop = false;
            // 
            // BirdPic
            // 
            BirdPic.Image = Properties.Resources.bird;
            BirdPic.Location = new Point(5500, 227);
            BirdPic.Margin = new Padding(0);
            BirdPic.Name = "BirdPic";
            BirdPic.Size = new Size(50, 41);
            BirdPic.SizeMode = PictureBoxSizeMode.StretchImage;
            BirdPic.TabIndex = 1;
            BirdPic.TabStop = false;
            // 
            // ScoreNumtxt
            // 
            ScoreNumtxt.AutoSize = true;
            ScoreNumtxt.BackColor = SystemColors.Control;
            ScoreNumtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreNumtxt.Location = new Point(79, 9);
            ScoreNumtxt.Margin = new Padding(0);
            ScoreNumtxt.Name = "ScoreNumtxt";
            ScoreNumtxt.Size = new Size(23, 28);
            ScoreNumtxt.TabIndex = 2;
            ScoreNumtxt.Text = "0";
            // 
            // TopScoretxt
            // 
            TopScoretxt.AutoSize = true;
            TopScoretxt.BackColor = SystemColors.Control;
            TopScoretxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TopScoretxt.Location = new Point(9, 42);
            TopScoretxt.Margin = new Padding(0);
            TopScoretxt.Name = "TopScoretxt";
            TopScoretxt.Size = new Size(107, 28);
            TopScoretxt.TabIndex = 2;
            TopScoretxt.Text = "Top Score :";
            // 
            // TopScoreNumtxt
            // 
            TopScoreNumtxt.AutoSize = true;
            TopScoreNumtxt.BackColor = SystemColors.Control;
            TopScoreNumtxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TopScoreNumtxt.Location = new Point(116, 42);
            TopScoreNumtxt.Margin = new Padding(0);
            TopScoreNumtxt.Name = "TopScoreNumtxt";
            TopScoreNumtxt.Size = new Size(23, 28);
            TopScoreNumtxt.TabIndex = 2;
            TopScoreNumtxt.Text = "0";
            // 
            // DecorativeDinoPic
            // 
            DecorativeDinoPic.Image = Properties.Resources.crouched_running;
            DecorativeDinoPic.Location = new Point(378, 138);
            DecorativeDinoPic.Margin = new Padding(0);
            DecorativeDinoPic.Name = "DecorativeDinoPic";
            DecorativeDinoPic.Size = new Size(219, 103);
            DecorativeDinoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            DecorativeDinoPic.TabIndex = 1;
            DecorativeDinoPic.TabStop = false;
            DecorativeDinoPic.Tag = "pause";
            DecorativeDinoPic.Visible = false;
            // 
            // Hinttxt
            // 
            Hinttxt.AutoSize = true;
            Hinttxt.BackColor = SystemColors.Control;
            Hinttxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Hinttxt.Location = new Point(225, 285);
            Hinttxt.Margin = new Padding(0);
            Hinttxt.Name = "Hinttxt";
            Hinttxt.Size = new Size(522, 28);
            Hinttxt.TabIndex = 2;
            Hinttxt.Tag = "pause";
            Hinttxt.Text = "Press R For Restart, Esc to Resume The Game or E For Exit !!";
            Hinttxt.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 450);
            Controls.Add(Hinttxt);
            Controls.Add(Restarttxt);
            Controls.Add(GameOvertxt);
            Controls.Add(TopScoreNumtxt);
            Controls.Add(ScoreNumtxt);
            Controls.Add(TopScoretxt);
            Controls.Add(Scoretxt);
            Controls.Add(BirdPic);
            Controls.Add(CactusPic);
            Controls.Add(DecorativeDinoPic);
            Controls.Add(DinoPic);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Google Challenging Game";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)DinoPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)CactusPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirdPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)DecorativeDinoPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox DinoPic;
        private Label Scoretxt;
        private Label GameOvertxt;
        private Label Restarttxt;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer JumpTimer;
        private PictureBox CactusPic;
        private PictureBox BirdPic;
        private Label ScoreNumtxt;
        private Label TopScoretxt;
        private Label TopScoreNumtxt;
        private PictureBox DecorativeDinoPic;
        private Label Hinttxt;
    }
}