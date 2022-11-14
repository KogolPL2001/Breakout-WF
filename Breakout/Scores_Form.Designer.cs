namespace Breakout
{
    partial class Scores_Form
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
            this.ScoresLabel = new System.Windows.Forms.Label();
            this.ScoresListBox = new System.Windows.Forms.ListBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoresLabel
            // 
            this.ScoresLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScoresLabel.AutoSize = true;
            this.ScoresLabel.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoresLabel.Location = new System.Drawing.Point(142, 39);
            this.ScoresLabel.Name = "ScoresLabel";
            this.ScoresLabel.Size = new System.Drawing.Size(125, 35);
            this.ScoresLabel.TabIndex = 0;
            this.ScoresLabel.Text = "Scores:";
            // 
            // ScoresListBox
            // 
            this.ScoresListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ScoresListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScoresListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoresListBox.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoresListBox.ForeColor = System.Drawing.Color.Black;
            this.ScoresListBox.FormattingEnabled = true;
            this.ScoresListBox.ItemHeight = 29;
            this.ScoresListBox.Location = new System.Drawing.Point(12, 77);
            this.ScoresListBox.Name = "ScoresListBox";
            this.ScoresListBox.Size = new System.Drawing.Size(358, 319);
            this.ScoresListBox.TabIndex = 1;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnButton.BackColor = System.Drawing.Color.Black;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnButton.ForeColor = System.Drawing.Color.White;
            this.ReturnButton.Location = new System.Drawing.Point(142, 425);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(117, 55);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Scores_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ScoresListBox);
            this.Controls.Add(this.ScoresLabel);
            this.Name = "Scores_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoresForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ScoresLabel;
        private ListBox ScoresListBox;
        private Button ReturnButton;
    }
}