using QuizEnlab.Data;

namespace QuizEnlab.Services.IServices
{
    public interface IUserAnswerService
    {
        public Task<UserAnswer?> SaveUserAnswerAsync(int quizId, int answerIdSelected);
    }
}
