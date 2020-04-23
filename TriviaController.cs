using System;
using System.Windows.Forms;

namespace csharptrivia2020
{
    public class TriviaController 
    {
        private readonly Form mainForm;
        private readonly QuestionForm questionForm;
        private readonly ResultsForm resultsForm;
        private QuizTestDouble quiz;

        public TriviaController(Form mainForm)
        {
            this.mainForm = mainForm;

            questionForm = new QuestionForm(this, mainForm);
            resultsForm = new ResultsForm(this, mainForm);
        }

        internal void StartNewGame()
        {
            this.quiz = new QuizTestDouble();
            mainForm.Hide();
            resultsForm.Hide();
            questionForm.Show(quiz);
        }

        internal void ShowViewResults()
        {
            questionForm.Hide();
            resultsForm.Show(quiz);

        
        }

        internal void ShowViewHome()
        {
            resultsForm.Hide();
            mainForm.Show();
        }
    }
}