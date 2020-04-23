namespace csharptrivia2020
{
    public class QuestionTestDouble : Question
    {

        public string QuestionText { get; private set; }

        public string[] AnswerOptions { get; private set; }


        public QuestionTestDouble(string questionText, string[] answerOptions)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
        }
    }
}