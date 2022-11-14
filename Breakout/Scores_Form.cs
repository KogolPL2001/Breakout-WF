using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Breakout
{
    public partial class Scores_Form : Form
    {
        private class ComparerClass : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                return ((Menu.PlayerInfo)y).Score.CompareTo(((Menu.PlayerInfo)x).Score);
            }
        }
        public Scores_Form()
        {
            InitializeComponent();
            ReturnButton.MouseEnter += OnMouseEnterReturnButton;
            ReturnButton.MouseLeave += OnMouseLeaveReturnButton;
            IComparer Comparer = new ComparerClass();
            Menu.PlayerList.Sort(Comparer);
            int i = 1;
            foreach(Menu.PlayerInfo pi in Menu.PlayerList)
            {
                ScoresListBox.Items.Add(i + ". " + pi.Name + " Score: " + pi.Score);
                i++;
            }
        }

        //Return Button control
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            Menu.ClickObjectSound.Play();
            this.Close();
        }

        private void OnMouseEnterReturnButton(object sender, EventArgs e)
        {
            ReturnButton.BackColor = System.Drawing.Color.FromArgb(46, 48, 51);
        }

        private void OnMouseLeaveReturnButton(object sender, EventArgs e)
        {
            ReturnButton.BackColor = System.Drawing.Color.Black;
        }
    }
}
