namespace Breakout
{
    partial class Menu
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
            this.GameTitle = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ScoresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameTitle.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.GameTitle.Location = new System.Drawing.Point(77, 16);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(196, 34);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "BREAKOUT";
            this.GameTitle.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayButton.BackColor = System.Drawing.Color.Black;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayButton.Location = new System.Drawing.Point(124, 68);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(102, 41);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OptionsButton.BackColor = System.Drawing.Color.Black;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OptionsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OptionsButton.Location = new System.Drawing.Point(124, 121);
            this.OptionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(102, 41);
            this.OptionsButton.TabIndex = 2;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AboutButton.BackColor = System.Drawing.Color.Black;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AboutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutButton.Location = new System.Drawing.Point(124, 173);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(102, 41);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(124, 275);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 41);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ScoresButton
            // 
            this.ScoresButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScoresButton.BackColor = System.Drawing.Color.Black;
            this.ScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScoresButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ScoresButton.Location = new System.Drawing.Point(124, 224);
            this.ScoresButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScoresButton.Name = "ScoresButton";
            this.ScoresButton.Size = new System.Drawing.Size(102, 41);
            this.ScoresButton.TabIndex = 5;
            this.ScoresButton.Text = "Scores";
            this.ScoresButton.UseVisualStyleBackColor = false;
            this.ScoresButton.Click += new System.EventHandler(this.Scores_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(334, 342);
            this.Controls.Add(this.ScoresButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.GameTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label GameTitle;
        private Button PlayButton;
        private Button OptionsButton;
        private Button AboutButton;
        private Button ExitButton;
        private Button ScoresButton;
    }
}