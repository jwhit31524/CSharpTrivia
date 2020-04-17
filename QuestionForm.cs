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
        private QuizTestDouble quiz = new QuizTestDouble();

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
            // Law of Demeter (Ask, don't tell)
            quiz.NextQuestion();
            RefreshLabels();
        }

        private void QuestionForm_Activated(object sender, EventArgs e)
        {
            RefreshLabels();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            quiz.PreviousQuestion();
            RefreshLabels();
        }

        private void RefreshLabels()
        {
            var question = quiz.CurrentQuestion;
            QuestionNumberLabel.Text = $"Question {quiz.CurrentNumber} of {quiz.NumberOfQuestions}";
            QuestionTextLabel.Text = $"{question.QuestionText}";

            AnswerA.Text = $"{question.AnswerOptions[0]}";
            AnswerB.Text = $"{question.AnswerOptions[1]}";
            AnswerC.Text = $"{question.AnswerOptions[2]}";
        }
    }
}
