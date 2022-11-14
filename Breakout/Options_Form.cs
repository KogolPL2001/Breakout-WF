using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    public partial class Options_Form : Form
    {
        
        public Options_Form()
        {
            InitializeComponent();
            ReturnButton.MouseEnter += OnMouseEnterReturnButton;
            ReturnButton.MouseLeave += OnMouseLeaveReturnButton;
            DifficultyComboBox.SelectedIndexChanged += DifficultyComboBox_SelectedIndexChanged; 
            DifficultyComboBox.SelectedIndex = Menu.DifficultyIndex;
            PaddleComboBox.SelectedIndexChanged += PaddleComboBox_SelectedIndexChanged;
            PaddleComboBox.SelectedIndex = Menu.ColorIndex;
        } 

        //Difficulty control 
        private void DifficultyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            Menu.DifficultyIndex = DifficultyComboBox.SelectedIndex;
        }

        //Paddle color control
        private void PaddleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            Menu.ColorIndex = PaddleComboBox.SelectedIndex;
        }

        //Return Button control
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            this.Close();
        }

        private void OnMouseEnterReturnButton(object sender, EventArgs e)
        {
            ReturnButton.BackColor = Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveReturnButton(object sender, EventArgs e)
        {
            ReturnButton.BackColor = Color.Black;
        }

        //TrackBar control
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            Menu.player.Volume = (float)trackBar1.Value/10;
        }

        private void VolumeLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
