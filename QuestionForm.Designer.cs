namespace csharptrivia2020
{
    partial class QuestionForm
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
            this.Q1Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_RadioButton3 = new System.Windows.Forms.RadioButton();
            this.B_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.A_RadioButton = new System.Windows.Forms.RadioButton();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Q1Label
            // 
            this.Q1Label.AutoSize = true;
            this.Q1Label.Location = new System.Drawing.Point(13, 13);
            this.Q1Label.Name = "Q1Label";
            this.Q1Label.Size = new System.Drawing.Size(58, 13);
            this.Q1Label.TabIndex = 1;
            this.Q1Label.Text = "Question 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What is 2 x 24?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.C_RadioButton3);
            this.panel1.Controls.Add(this.B_RadioButton2);
            this.panel1.Controls.Add(this.A_RadioButton);
            this.panel1.Location = new System.Drawing.Point(16, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 251);
            this.panel1.TabIndex = 5;
            // 
            // C_RadioButton3
            // 
            this.C_RadioButton3.AutoSize = true;
            this.C_RadioButton3.Location = new System.Drawing.Point(4, 66);
            this.C_RadioButton3.Name = "C_RadioButton3";
            this.C_RadioButton3.Size = new System.Drawing.Size(37, 17);
            this.C_RadioButton3.TabIndex = 2;
            this.C_RadioButton3.TabStop = true;
            this.C_RadioButton3.Text = "36";
            this.C_RadioButton3.UseVisualStyleBackColor = true;
            // 
            // B_RadioButton2
            // 
            this.B_RadioButton2.AutoSize = true;
            this.B_RadioButton2.Location = new System.Drawing.Point(4, 43);
            this.B_RadioButton2.Name = "B_RadioButton2";
            this.B_RadioButton2.Size = new System.Drawing.Size(37, 17);
            this.B_RadioButton2.TabIndex = 1;
            this.B_RadioButton2.TabStop = true;
            this.B_RadioButton2.Text = "48";
            this.B_RadioButton2.UseVisualStyleBackColor = true;
            // 
            // A_RadioButton
            // 
            this.A_RadioButton.AutoSize = true;
            this.A_RadioButton.Location = new System.Drawing.Point(4, 20);
            this.A_RadioButton.Name = "A_RadioButton";
            this.A_RadioButton.Size = new System.Drawing.Size(37, 17);
            this.A_RadioButton.TabIndex = 0;
            this.A_RadioButton.TabStop = true;
            this.A_RadioButton.Text = "56";
            this.A_RadioButton.UseVisualStyleBackColor = true;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Location = new System.Drawing.Point(592, 342);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(116, 23);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q1Label);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Q1Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton C_RadioButton3;
        private System.Windows.Forms.RadioButton B_RadioButton2;
        private System.Windows.Forms.RadioButton A_RadioButton;
        private System.Windows.Forms.Button NextQuestionButton;
    }
}