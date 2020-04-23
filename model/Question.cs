namespace csharptrivia2020.model
{
    public interface Question
    {
        string[] AnswerOptions { get; }
        string QuestionText { get; }
    }
}