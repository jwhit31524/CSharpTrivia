using System;
using System.Collections.Generic;

namespace csharptrivia2020
{
    public class QuizTestDouble
    {
        public int NumberOfQuestions
        {
            get { return _questionList.Length; }
            set { }
        }
        public QuestionTestDouble CurrentQuestion { 
            get { return _questionList[_currrentIndex];  }
            private set { }  
        }
        public int CurrentQuestionNumber
        {
            get { return _currrentIndex + 1; }
            private set { }
        }

        public bool OnLastQuestion {
            get { return CurrentQuestionNumber == NumberOfQuestions; }
            internal set { }
        }

        public bool OnFirstQuestion {
            get { return CurrentQuestionNumber == 1; }
            internal set
            { }
        }

        private QuestionTestDouble[] _questionList = new QuestionTestDouble[5];
        private int _currrentIndex;

        public QuizTestDouble()
        {
            _questionList[0] = new QuestionTestDouble(
                "What is 2 x 24?",
                new[] { "24", "48", "56" }
                );
            _questionList[1] = new QuestionTestDouble(
               "What is the capital of Michigan?",
               new[] { "Detroit", "Lansing", "Farmington Hills" }
               );
            _questionList[2] = new QuestionTestDouble(
                 "What is 14 x 5?",
                new[] { "122", "234", "70" }
                );
            _questionList[3] = new QuestionTestDouble(
                "What is a branch of U.S. government?",
                new[] { "Crayon", "Executive", "Vehicle" }
                );
            _questionList[4] = new QuestionTestDouble(
                "What is a type of bear",
                new[] { "Leopard", "Polar", "Giraffe" }
                );

            _currrentIndex = 0;
        }

        internal void NextQuestion()
        {
            _currrentIndex++;
        }

        internal void PreviousQuestion()
        {
            _currrentIndex--;
        }
    }
}