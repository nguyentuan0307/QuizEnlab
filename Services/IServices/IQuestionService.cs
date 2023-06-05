using QuizEnlab.Model;

namespace QuizEnlab.Services.IServices
{
    public interface IQuestionService
    {
        public Task<QuestionModel?> GetFirstQuestionAsync(int quizId);
        public Task<NextQuestionResult?> GetNextQuestionAsync(int quizId);
        public Task<QuestionsModel?> GetQuestionsAsync(int quizId);
    }
}
