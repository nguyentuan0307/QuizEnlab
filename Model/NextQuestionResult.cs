using QuizEnlab.Data;

namespace QuizEnlab.Model
{
    public class NextQuestionResult
    {
        public bool IsQuiz { get; set; } = true;
        public bool IsQuestion { get; set; } = true;
        public ResultModel? ResultModel { get; set; } = null;
        public QuestionModel? Question { get; set; }
    }
}
