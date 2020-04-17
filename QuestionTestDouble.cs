namespace csharptrivia2020
{
    internal class QuestionTestDouble
    {
      
        internal readonly string QuestionText;
        internal readonly string[] AnswerOptions;

   
        public QuestionTestDouble(string questionText, string[] answerOptions)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
        }
    }
}