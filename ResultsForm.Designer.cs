namespace csharptrivia2020
{
    partial class ResultsForm
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
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.Question1Label = new System.Windows.Forms.Label();
            this.GuessedLabel1 = new System.Windows.Forms.Label();
            this.CorrectLabel1 = new System.Windows.Forms.Label();
            this.FinalScoreLabel = new System.Windows.Forms.Label();
            this.CloseGameButton = new System.Windows.Forms.Button();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(13, 22);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(81, 13);
            this.ResultsLabel.TabIndex = 0;
            this.ResultsLabel.Text = "Results of Quiz:";
            // 
            // Question1Label
            // 
            this.Question1Label.AutoSize = true;
            this.Question1Label.Location = new System.Drawing.Point(16, 68);
            this.Question1Label.Name = "Question1Label";
            this.Question1Label.Size = new System.Drawing.Size(58, 13);
            this.Question1Label.TabIndex = 1;
            this.Question1Label.Text = "Question 1";
            // 
            // GuessedLabel1
            // 
            this.GuessedLabel1.AutoSize = true;
            this.GuessedLabel1.Location = new System.Drawing.Point(12, 91);
            this.GuessedLabel1.Name = "GuessedLabel1";
            this.GuessedLabel1.Size = new System.Drawing.Size(74, 13);
            this.GuessedLabel1.TabIndex = 2;
            this.GuessedLabel1.Text = "You Guessed:";
            // 
            // CorrectLabel1
            // 
            this.CorrectLabel1.AutoSize = true;
            this.CorrectLabel1.Location = new System.Drawing.Point(12, 114);
            this.CorrectLabel1.Name = "CorrectLabel1";
            this.CorrectLabel1.Size = new System.Drawing.Size(82, 13);
            this.CorrectLabel1.TabIndex = 3;
            this.CorrectLabel1.Text = "Correct Answer:";
            // 
            // FinalScoreLabel
            // 
            this.FinalScoreLabel.AutoSize = true;
            this.FinalScoreLabel.Location = new System.Drawing.Point(12, 343);
            this.FinalScoreLabel.Name = "FinalScoreLabel";
            this.FinalScoreLabel.Size = new System.Drawing.Size(60, 13);
            this.FinalScoreLabel.TabIndex = 4;
            this.FinalScoreLabel.Text = "Final Score";
            // 
            // CloseGameButton
            // 
            this.CloseGameButton.Location = new System.Drawing.Point(593, 377);
            this.CloseGameButton.Name = "CloseGameButton";
            this.CloseGameButton.Size = new System.Drawing.Size(75, 23);
            this.CloseGameButton.TabIndex = 5;
            this.CloseGameButton.Text = "Close Game";
            this.CloseGameButton.UseVisualStyleBackColor = true;
            this.CloseGameButton.Click += new System.EventHandler(this.CloseGameButton_Click);
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.Location = new System.Drawing.Point(479, 377);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(75, 23);
            this.PlayAgainButton.TabIndex = 6;
            this.PlayAgainButton.Text = "Play Again";
            this.PlayAgainButton.UseVisualStyleBackColor = true;
            this.PlayAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayAgainButton);
            this.Controls.Add(this.CloseGameButton);
            this.Controls.Add(this.FinalScoreLabel);
            this.Controls.Add(this.CorrectLabel1);
            this.Controls.Add(this.GuessedLabel1);
            this.Controls.Add(this.Question1Label);
            this.Controls.Add(this.ResultsLabel);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label Question1Label;
        private System.Windows.Forms.Label GuessedLabel1;
        private System.Windows.Forms.Label CorrectLabel1;
        private System.Windows.Forms.Label FinalScoreLabel;
        private System.Windows.Forms.Button CloseGameButton;
        private System.Windows.Forms.Button PlayAgainButton;
    }
}