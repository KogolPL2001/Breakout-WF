using System.Collections;
using System.Media;

namespace Breakout
{
    public partial class Menu : Form
    {
        public static System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        public static int DifficultyIndex = 0; 
        public static int ColorIndex = 0; 
        public static SoundPlayer ClickObjectSound = new SoundPlayer(@"C:\Users\Legion\source\repos\Breakout\Breakout\Resources\pingpongsound.wav");
        public static SoundPlayer GameOverSound = new SoundPlayer(@"C:\Users\Legion\source\repos\Breakout\Breakout\Resources\gameoversound.wav");
        public struct PlayerInfo
        {
            public string Name;
            public string Score;
        }
        public static ArrayList PlayerList;
        public Menu()
        {
            InitializeComponent();
            PlayerList = new ArrayList();
            PlayButton.MouseEnter += OnMouseEnterPlayButton;
            OptionsButton.MouseEnter += OnMouseEnterOptionsButton;
            AboutButton.MouseEnter += OnMouseEnterAboutButton;
            ScoresButton.MouseEnter += OnMouseEnterScoresButton;
            ExitButton.MouseEnter += OnMouseEnterExitButton;

            PlayButton.MouseLeave += OnMouseLeavePlayButton;
            OptionsButton.MouseLeave += OnMouseLeaveOptionsButton;
            AboutButton.MouseLeave += OnMouseLeaveAboutButton;
            ScoresButton.MouseLeave += OnMouseLeaveScoresButton;
            ExitButton.MouseLeave += OnMouseLeaveExitButton;

            player.MediaEnded += MediaEnded;
            player.Open(new Uri(@"C:\Users\Legion\source\repos\Breakout\Breakout\Resources\gigachad meme sound effect.wav"));
            player.Play();
            player.Volume = (float)0.1;
        }
        public void MediaEnded(object sender, EventArgs e)
        {
            player.Open(new Uri(@"C:\Users\Legion\source\repos\Breakout\Breakout\Resources\gigachad meme sound effect.wav"));
            player.Play();
        }
        //title label control
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        //Play Button control
        private void playButton_Click(object sender, EventArgs e)
        {
            ClickObjectSound.Play();
            Game_Form gameForm = new Game_Form();
            this.Hide();
            gameForm.ShowDialog();
            if (!FormIsOpen(Application.OpenForms, typeof(Options_Form)))
                this.Show();
        }

        private void OnMouseEnterPlayButton(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.FromArgb(46, 48, 51); 
        }

        private void OnMouseLeavePlayButton(object sender, EventArgs e)
        {
            PlayButton.BackColor = Color.Black;
        }

        //Options Button control
        private void OptionsButton_Click(object sender, EventArgs e)
        {
            ClickObjectSound.Play();
            Options_Form optionsForm = new Options_Form();
            this.Hide();
            optionsForm.ShowDialog();
            if (!FormIsOpen(Application.OpenForms, typeof(Options_Form))) 
                this.Show();
        }
        public static bool FormIsOpen(FormCollection application,Type formType)
        {
            return Application.OpenForms.Cast<Form>().Any(openForm => openForm.GetType() == formType);
        }
        
        private void OnMouseEnterOptionsButton(object sender, EventArgs e)
        {
            OptionsButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveOptionsButton(object sender, EventArgs e)
        {
            OptionsButton.BackColor = Color.Black;
        }

        //About Button control
        private void AboutButton_Click(object sender, EventArgs e)
        {
            ClickObjectSound.Play();
            About_Form aboutForm = new About_Form();
            this.Hide();
            aboutForm.ShowDialog();
            if (!FormIsOpen(Application.OpenForms, typeof(Options_Form)))
                this.Show();
        }
        private void OnMouseEnterAboutButton(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveAboutButton(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.Black;
        }

        //Scores Button control

        private void Scores_Click(object sender, EventArgs e)
        {
            ClickObjectSound.Play();
            Scores_Form scoresForm = new Scores_Form();
            this.Hide();
            scoresForm.ShowDialog();
            if (!FormIsOpen(Application.OpenForms, typeof(Options_Form)))
                this.Show();
        }
        private void OnMouseEnterScoresButton(object sender, EventArgs e)
        {
            ScoresButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveScoresButton(object sender, EventArgs e)
        {
            ScoresButton.BackColor = Color.Black;
        }

        //Exit Button control
        private void exitButton_Click(object sender, EventArgs e)
        {
            ClickObjectSound.Play();
            Application.Exit();
        }
        private void OnMouseEnterExitButton(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveExitButton(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Black;
        }
    }
}