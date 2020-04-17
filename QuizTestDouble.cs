namespace csharptrivia2020
{
    internal class QuizTestDouble
    {
        internal readonly int NumberOfQuestions;
        internal readonly QuestionTestDouble CurrentQuestion;
        internal readonly int CurrentNumber;

        public QuizTestDouble()
        {
            NumberOfQuestions = 5;
            var question = new QuestionTestDouble(
                "What is 2 x 24?",
                new[] { "24", "48", "56" }
                );
            var question2 = new QuestionTestDouble(
               "What is the capital of Michigan?",
               new[] { "Detroit", "Lansing", "Farmington Hills" }
               );
            var question3 = new QuestionTestDouble(
                 "What is 14 x 5?",
                new[] { "122", "234", "70" }
                );
            var question4 = new QuestionTestDouble(
                "What is a branch of U.S. government?",
                new[] { "Crayon", "Executive", "Vehicle" }
                );
            var question5 = new QuestionTestDouble(
                "What is a type of bear",
                new[] { "Leopard", "Polar", "Giraffe" }
                );

            CurrentQuestion = question;
            CurrentNumber = 1;
        }
    }
}