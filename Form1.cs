using System.Security.Cryptography;

namespace Google_Dino_Final
{
    public partial class Form1 : Form
    {

        bool JumpMore = true;
        bool GameOver = false;
        bool Crouched = false;
        bool GamePaused = false;
        bool WasJumping = false;
        byte a;
        int ObjectMoveSpeed = 5;
        int ChosenObj;
        Random NumPicker = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void GameRestart()  // شروع دوباره  *****
        {
            // برگرداندن به حالت پیش فرض
            GameOver = false;
            MainTimer.Start();
            JumpMore = true;
            GameOvertxt.Visible = false;
            Restarttxt.Visible = false;
            ObjectMoveSpeed = 5;
            DinoPic.ImageLocation = @"img\normal-running.gif";
            DinoPic.Top = 317;
            BirdPic.Left = 8500;
            CactusPic.Left = 1500;
            ScoreNumtxt.Text = "0";
        }

        private void JumpTimer_Tick(object sender, EventArgs e)  // پریدن به کمک تایمر  ******
        {
            if (JumpMore) // بالا رفتن تا جای ممکن
            {
                DinoPic.Top -= 9;
                JumpTimer.Interval += 1;
                if (DinoPic.Top == 137) JumpMore = false;
            }
            else // پایین آمدن
            {
                DinoPic.Top += 9;
                JumpTimer.Interval -= 1;
                if (DinoPic.Top == 317)
                {
                    JumpTimer.Stop();
                    JumpMore = true;
                }
            }
        }
        

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            if (BirdPic.Left == CactusPic.Left)
                BirdPic.Left += 500;

            if ((CactusPic.Left >= this.Width - 5) && (CactusPic.Left <= this.Width + 5))   // انتخاب کاکتوس تصادفی
            {
                ChosenObj = NumPicker.Next(1, 8);
                CactusPic.ImageLocation = "img\\" + ChosenObj + ".png";
            }
            CactusPic.Top = label1.Top - CactusPic.Height;

            if (BirdPic.Left >= this.Width)  // انتخاب مکان پرنده
            {
                switch (NumPicker.Next(1, 4))
                {
                    case 1:
                        {
                            BirdPic.Top = 324;
                            break;
                        }
                    case 2:
                        {
                            BirdPic.Top = 287;
                            break;
                        }
                    case 3:
                        {
                            BirdPic.Top = 227;
                            break;
                        }
                }
            }

            BirdPic.Left -= ObjectMoveSpeed;    // حرکت دادن پرنده
            CactusPic.Left -= ObjectMoveSpeed;  // حرکن کاکتوس

            // برخورد با اجسام   *******
            if (DinoPic.Bounds.IntersectsWith(CactusPic.Bounds) || DinoPic.Bounds.IntersectsWith(BirdPic.Bounds))
            {
                DinoPic.ImageLocation = @"img\dead.png";
                MainTimer.Stop();
                JumpTimer.Stop();
                GameOver = true;
                if ((int.Parse(TopScoreNumtxt.Text)) < (int.Parse(ScoreNumtxt.Text)))
                {
                    TopScoreNumtxt.Text = ScoreNumtxt.Text;
                }
                Restarttxt.Visible = true;
                GameOvertxt.Visible = true;
            }

            if (CactusPic.Right <= 0)   // برگشتن کاکتوس به نقطه اول
            {
                ScoreNumtxt.Text = (int.Parse(ScoreNumtxt.Text) + 1).ToString();
                CactusPic.Left = 1000;
                a++;
            }

            if (BirdPic.Right <= 0)
            {
                BirdPic.Left += 5000;
                ScoreNumtxt.Text = (int.Parse(ScoreNumtxt.Text) + 1).ToString();
                a++;
            }

            if (a > 7)
            {
                ObjectMoveSpeed++;
                a = 0;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)   // فشردن کلید ها  ******
        {
            if (!GameOver)
            {
                if (("Up" == e.KeyCode.ToString()) && (317 == DinoPic.Top) && (!Crouched) && (!GamePaused))  // جهت بالا و پریدن
                {
                    JumpTimer.Start();
                }
                else if (("Down" == e.KeyCode.ToString()) && (317 == DinoPic.Top) && (!GamePaused))  // جهت پایین و خم شدن
                {
                    Crouched = true;
                    DinoPic.Top = 330;
                    DinoPic.ImageLocation = @"img\crouched-running.gif";
                }
                else if ("Escape" == e.KeyCode.ToString())  //  منوی پاز  ***********
                {

                    MainTimer.Enabled = !MainTimer.Enabled;
                    if (JumpTimer.Enabled)
                    {
                        WasJumping = true;
                        JumpTimer.Stop();
                    }
                    else if (WasJumping)
                    {
                        WasJumping = false;
                        JumpTimer.Start();
                    }

                    GamePaused = !GamePaused;

                    Hinttxt.Visible = !Hinttxt.Visible;
                    DecorativeDinoPic.Visible = !DecorativeDinoPic.Visible;
                    ScoreNumtxt.Visible = !ScoreNumtxt.Visible;
                    Scoretxt.Visible = !Scoretxt.Visible;
                    TopScoreNumtxt.Visible = !TopScoreNumtxt.Visible;
                    TopScoretxt.Visible = !TopScoretxt.Visible;
                    label1.Visible = !label1.Visible;
                    label2.Visible = !label2.Visible;
                    CactusPic.Visible = !CactusPic.Visible;
                    DinoPic.Visible = !DinoPic.Visible;
                    BirdPic.Visible = !BirdPic.Visible;
                }
                else if ((GamePaused) && ("R" == e.KeyCode.ToString()))  // فراخانی تابع برای شروع دوباره
                    GameRestart();
                else if ((GamePaused) && ("E" == e.KeyCode.ToString()))  // بستن بازی
                    this.Close();
            }
            else
                GameRestart();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)  // بالا آمدن کلید  ******
        {
            if ("Down" == e.KeyCode.ToString() && (Crouched))
            {
                Crouched = false;
                DinoPic.Top = 317;
                DinoPic.ImageLocation = @"img\normal-running.gif";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}