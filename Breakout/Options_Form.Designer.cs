namespace Breakout
{
    partial class Options_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PaddleComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeLabel.Location = new System.Drawing.Point(110, 19);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(179, 29);
            this.VolumeLabel.TabIndex = 0;
            this.VolumeLabel.Text = "Music Volume";
            this.VolumeLabel.Click += new System.EventHandler(this.VolumeLabel_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.Location = new System.Drawing.Point(135, 51);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnButton.BackColor = System.Drawing.Color.Black;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReturnButton.Location = new System.Drawing.Point(142, 320);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(117, 55);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Difficulty:";
            // 
            // DifficultyComboBox
            // 
            this.DifficultyComboBox.BackColor = System.Drawing.Color.Black;
            this.DifficultyComboBox.ForeColor = System.Drawing.Color.White;
            this.DifficultyComboBox.FormattingEnabled = true;
            this.DifficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyComboBox.Location = new System.Drawing.Point(202, 111);
            this.DifficultyComboBox.Name = "DifficultyComboBox";
            this.DifficultyComboBox.Size = new System.Drawing.Size(151, 28);
            this.DifficultyComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paddle color:";
            // 
            // PaddleComboBox
            // 
            this.PaddleComboBox.BackColor = System.Drawing.Color.Black;
            this.PaddleComboBox.ForeColor = System.Drawing.Color.White;
            this.PaddleComboBox.FormattingEnabled = true;
            this.PaddleComboBox.Items.AddRange(new object[] {
            "White",
            "Yellow",
            "Blue",
            "Red",
            "Green",
            "Purple",
            "Orange"});
            this.PaddleComboBox.Location = new System.Drawing.Point(202, 152);
            this.PaddleComboBox.Name = "PaddleComboBox";
            this.PaddleComboBox.Size = new System.Drawing.Size(151, 28);
            this.PaddleComboBox.TabIndex = 6;
            // 
            // Options_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.PaddleComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DifficultyComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.VolumeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Options_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options_Formcs";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label VolumeLabel;
        private TrackBar trackBar1;
        private Button ReturnButton;
        private Label label1;
        private ComboBox DifficultyComboBox;
        private Label label2;
        private ComboBox PaddleComboBox;
    }
}