using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharptrivia2020
{
    public partial class QuestionForm : Form
    {
        private TriviaController triviaController;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(TriviaController triviaController, Form formOwner)
        {
            InitializeComponent();
            this.triviaController = triviaController;
            Owner = formOwner;
        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            triviaController.ShowViewResults();

        }

        private void QuestionForm_Activated(object sender, EventArgs e)
        {
            var question = new QuestionTestDouble();
            var quiz = new QuizTestDouble();
            QuestionNumberLabel.Text = $"Question {question.Number} of {quiz.NumberOfQuestions}";
            QuestionTextLabel.Text = $"{question.QuestionText}";

            AnswerA.Text = $"{question.AnswerOptions[0]}";
            AnswerB.Text = $"{question.AnswerOptions[1]}";
            AnswerC.Text = $"{question.AnswerOptions[2]}";
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void QuestionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void QuestionNumberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
