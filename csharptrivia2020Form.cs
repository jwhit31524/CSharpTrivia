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
    public partial class CSharpTrivia2020Form : Form
    {
        public CSharpTrivia2020Form()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            form.Tag = this;
            form.Show(this);
            Hide();
        }
    }
}
