namespace csharptrivia2020
{
    internal class QuestionTestDouble
    {
        internal readonly int Number;
        internal readonly string QuestionText;
        internal readonly string[] AnswerOptions;

        public QuestionTestDouble()
        {
            Number = 1;
            QuestionText = "What is 2 x 24?";
            AnswerOptions = new[] { "24", "48", "56" };
        }
    }
}