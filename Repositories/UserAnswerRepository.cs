using Microsoft.EntityFrameworkCore;
using QuizEnlab.Data;
using QuizEnlab.Repositories.IRepository;

namespace QuizEnlab.Repositories
{
    public class UserAnswerRepository : IUserAnswerRepository
    {
        private readonly DataContext _dataContext;

        public UserAnswerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<HashSet<int>> GetAllQuestionIdAsync(int quizId)
        {
            var questionIds = await _dataContext.UserAnswers
                .Where(a => a.QuizId == quizId)
                .Select(a => a.Answer.QuestionId)
                .ToListAsync();
            return new HashSet<int>(questionIds);
        }

        public async Task<int> GetAnswerReviewIdByQuestionsAsync(int quizId, Question question)
        {
            var userAnswer = await _dataContext.UserAnswers
                .FirstOrDefaultAsync(a => a.QuizId == quizId && a.Answer.QuestionId == question.Id);

            if (userAnswer != null)
            {
                return userAnswer.Answer.Id;
            }

            return -1; // Giá trị mặc định khi không tìm thấy câu trả lời
        }

        public async Task<int> GetCorrectAnswerCount(int quizId)
        {
            var correctAnswerCount = await _dataContext.UserAnswers
                .CountAsync(a => a.QuizId == quizId && a.Answer.IsCorrect);
            return correctAnswerCount;
        }

        public async Task<int> GetTotalQuestionCount(int quizId)
        {
            var totalQuestionCount = await _dataContext.UserAnswers
                .Where(a => a.QuizId == quizId)
                .Select(a => a.Answer.QuestionId)
                .Distinct()
                .CountAsync();
            return totalQuestionCount;
        }

        public async Task<UserAnswer> SaveUserAnswerAsync(UserAnswer userAnswer)
        {
            await _dataContext.UserAnswers.AddAsync(userAnswer);
            await _dataContext.SaveChangesAsync();
            return userAnswer;
        }
    }
}
