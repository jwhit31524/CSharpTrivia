namespace csharptrivia2020
{
    public interface Question
    {
        string[] AnswerOptions { get; }
        string QuestionText { get; }
    }
}