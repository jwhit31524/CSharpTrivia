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
    public partial class ResultsForm : Form
    {
        private readonly TriviaController triviaController;
        private readonly Form mainForm;

        public ResultsForm()
        {
            InitializeComponent();
        }

        public ResultsForm(TriviaController triviaController, Form formOwner)
        {
            InitializeComponent();
            this.triviaController = triviaController;
            Owner = formOwner;
        }

        private void CloseGameButton_Click(object sender, EventArgs e)
        {
            triviaController.ShowViewHome();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            triviaController.StartNewGame();
        }
    }
}
