using QuizEnlab.Data;
using QuizEnlab.Model;

namespace QuizEnlab.Repositories.IRepository
{
    public interface IUserAnswerRepository
    {
        public Task<UserAnswer> SaveUserAnswerAsync(UserAnswer userAnswer);
        public Task<HashSet<int>> GetAllQuestionIdAsync(int quizId);
        public Task<int> GetCorrectAnswerCount(int quizId);
        public Task<int> GetTotalQuestionCount(int quizId);
        public Task<int> GetAnswerReviewIdByQuestionsAsync(int quizId, Question question);

    }
}
