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
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();
            ReturnButton.MouseEnter += OnMouseEnterReturnButton;
            ReturnButton.MouseLeave += OnMouseLeaveReturnButton;
        }

        //Return Button control
        private void ReturnButton_Click(object sender, EventArgs e)
        {
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
