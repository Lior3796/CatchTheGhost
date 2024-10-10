using System.Timers;

namespace CatchTheGhost
{
    public partial class MainForm : Form
    {
        string dataDirBasePath = @"Data\Songs";
        int timerCount;
        int gameScore;
        Music clickMusic = new Music();
        Music gameMusic = new Music();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            gameMusic.Play($@"{dataDirBasePath}\Ghost.mp3");
            tGame.Enabled = true;
            pbGhost.Visible = true;
            timerCount = timerCount - 1;
            timerCount = 15;
            gameScore = 0;
            lblTimerCount.Text = "Timer: " + timerCount.ToString();
            lblGameScore.Text = "Score: " + gameScore.ToString();
            lblTimerCount.Visible = true;
            lblGameScore.Visible = true;
        }

        private void pbGhost_Click(object sender, EventArgs e)
        {
            pbGhost.Visible = false;
            gameScore = gameScore + 1;
            clickMusic.Play($@"{dataDirBasePath}\Click.mp3");
            lblGameScore.Text = "Score: " + gameScore.ToString();
        }

        private void tGame_Tick(object sender, EventArgs e)
        {
            if (timerCount <= 0 || gameScore >= 10)
            {
                tGame.Enabled = false;
                pbGhost.Width = 120;
                pbGhost.Height = 120;
                pbGhost.Visible = false;

                bool isUserWon = gameScore >= 10;
                gameMusic.Stop();
                gameMusic.Play(isUserWon ? $@"{dataDirBasePath}\win.mp3" : $@"{dataDirBasePath}\lose.mp3");
                btnStart.Visible = true;
                pbGhost.Visible = false;
                MessageBox.Show(isUserWon ? "You win" : "You lose");
                gameMusic.Stop();

                return;
            }

            timerCount = timerCount - 1;
            lblTimerCount.Text = "Timer: " + timerCount.ToString();
            if (pbGhost.Width >= 30)
            {
                pbGhost.Width = pbGhost.Width - 10;
            }
            if (pbGhost.Height >= 30)
            {
                pbGhost.Height = pbGhost.Height - 10;
            }

            Random rand = new Random();
            int X = rand.Next(0, 680);
            int Y = rand.Next(120, 380);
            Point randPoint = new Point(X, Y);
            pbGhost.Location = randPoint;
            pbGhost.Visible = true;
        }
    }
}
