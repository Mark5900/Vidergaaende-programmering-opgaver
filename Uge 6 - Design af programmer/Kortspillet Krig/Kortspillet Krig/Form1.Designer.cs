namespace Kortspillet_Krig
{
    partial class Form1
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
            this.DealButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.CardTextBox = new System.Windows.Forms.TextBox();
            this.ScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerTwoScoreLabel = new System.Windows.Forms.Label();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.PlayerOneScoreLabel = new System.Windows.Forms.Label();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerOneCard = new System.Windows.Forms.PictureBox();
            this.PlayerTwoCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScoreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoCard)).BeginInit();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(352, 26);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(88, 33);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Enabled = false;
            this.PlayButton.Location = new System.Drawing.Point(352, 66);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(88, 31);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // CardTextBox
            // 
            this.CardTextBox.Location = new System.Drawing.Point(352, 199);
            this.CardTextBox.Multiline = true;
            this.CardTextBox.Name = "CardTextBox";
            this.CardTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CardTextBox.Size = new System.Drawing.Size(262, 66);
            this.CardTextBox.TabIndex = 2;
            this.CardTextBox.Visible = false;
            // 
            // ScoreGroupBox
            // 
            this.ScoreGroupBox.Controls.Add(this.PlayerTwoScoreLabel);
            this.ScoreGroupBox.Controls.Add(this.PlayerTwoLabel);
            this.ScoreGroupBox.Controls.Add(this.PlayerOneScoreLabel);
            this.ScoreGroupBox.Controls.Add(this.PlayerOneLabel);
            this.ScoreGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreGroupBox.Location = new System.Drawing.Point(353, 104);
            this.ScoreGroupBox.Name = "ScoreGroupBox";
            this.ScoreGroupBox.Size = new System.Drawing.Size(121, 64);
            this.ScoreGroupBox.TabIndex = 3;
            this.ScoreGroupBox.TabStop = false;
            this.ScoreGroupBox.Text = "Scores";
            // 
            // PlayerTwoScoreLabel
            // 
            this.PlayerTwoScoreLabel.AutoSize = true;
            this.PlayerTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoScoreLabel.Location = new System.Drawing.Point(62, 42);
            this.PlayerTwoScoreLabel.Name = "PlayerTwoScoreLabel";
            this.PlayerTwoScoreLabel.Size = new System.Drawing.Size(13, 15);
            this.PlayerTwoScoreLabel.TabIndex = 3;
            this.PlayerTwoScoreLabel.Text = "0";
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.AutoSize = true;
            this.PlayerTwoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerTwoLabel.Location = new System.Drawing.Point(7, 42);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(51, 15);
            this.PlayerTwoLabel.TabIndex = 2;
            this.PlayerTwoLabel.Text = "Player2: ";
            // 
            // PlayerOneScoreLabel
            // 
            this.PlayerOneScoreLabel.AutoSize = true;
            this.PlayerOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneScoreLabel.Location = new System.Drawing.Point(62, 23);
            this.PlayerOneScoreLabel.Name = "PlayerOneScoreLabel";
            this.PlayerOneScoreLabel.Size = new System.Drawing.Size(13, 15);
            this.PlayerOneScoreLabel.TabIndex = 1;
            this.PlayerOneScoreLabel.Text = "0";
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.AutoSize = true;
            this.PlayerOneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayerOneLabel.Location = new System.Drawing.Point(7, 23);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(48, 15);
            this.PlayerOneLabel.TabIndex = 0;
            this.PlayerOneLabel.Text = "Player1:";
            // 
            // PlayerOneCard
            // 
            this.PlayerOneCard.Location = new System.Drawing.Point(12, 25);
            this.PlayerOneCard.Name = "PlayerOneCard";
            this.PlayerOneCard.Size = new System.Drawing.Size(157, 240);
            this.PlayerOneCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerOneCard.TabIndex = 4;
            this.PlayerOneCard.TabStop = false;
            // 
            // PlayerTwoCard
            // 
            this.PlayerTwoCard.Location = new System.Drawing.Point(174, 25);
            this.PlayerTwoCard.Name = "PlayerTwoCard";
            this.PlayerTwoCard.Size = new System.Drawing.Size(157, 240);
            this.PlayerTwoCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTwoCard.TabIndex = 5;
            this.PlayerTwoCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player1 Card:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(174, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player2 Card:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerTwoCard);
            this.Controls.Add(this.PlayerOneCard);
            this.Controls.Add(this.ScoreGroupBox);
            this.Controls.Add(this.CardTextBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DealButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ScoreGroupBox.ResumeLayout(false);
            this.ScoreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOneCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTwoCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox CardTextBox;
        private System.Windows.Forms.GroupBox ScoreGroupBox;
        private System.Windows.Forms.Label PlayerTwoScoreLabel;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.Label PlayerOneScoreLabel;
        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.PictureBox PlayerOneCard;
        private System.Windows.Forms.PictureBox PlayerTwoCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
