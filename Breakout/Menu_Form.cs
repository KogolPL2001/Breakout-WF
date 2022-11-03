namespace Breakout
{
    public partial class Menu : Form
    {
        public static System.Windows.Media.MediaPlayer player = new System.Windows.Media.MediaPlayer();
        public Menu()
        {
            InitializeComponent();
            PlayButton.MouseEnter += OnMouseEnterPlayButton;
            OptionsButton.MouseEnter += OnMouseEnterOptionsButton;
            AboutButton.MouseEnter += OnMouseEnterAboutButton;
            ExitButton.MouseEnter += OnMouseEnterExitButton;

            PlayButton.MouseLeave += OnMouseLeavePlayButton;
            OptionsButton.MouseLeave += OnMouseLeaveOptionsButton;
            AboutButton.MouseLeave += OnMouseLeaveAboutButton;
            ExitButton.MouseLeave += OnMouseLeaveExitButton;
            player.Open(new Uri(@"C:\Users\Legion\source\repos\Breakout\Breakout\Resources\gigachad meme sound effect.wav"));
            player.Play();
        }
        //Title label control
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        //Play Button control
        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        }
        private void OnMouseEnterAboutButton(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveAboutButton(object sender, EventArgs e)
        {
            AboutButton.BackColor = Color.Black;
        }

        //Exit Button control
        private void exitButton_Click(object sender, EventArgs e)
        {
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