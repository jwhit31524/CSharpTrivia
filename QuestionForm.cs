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
    }
}
