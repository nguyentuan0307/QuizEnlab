using Microsoft.EntityFrameworkCore;
using QuizEnlab.Data;
using QuizEnlab.Repositories.IRepository;

namespace QuizEnlab.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly DataContext _dataContext;

        public QuizRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Quiz?> CreateQuizAsync(Quiz quiz)
        {
            await _dataContext.Quizzes.AddAsync(quiz);
            await _dataContext.SaveChangesAsync();
            return quiz;
        }

        public async Task<List<Quiz>> GetAllQuizsAsync()
        {
            return await _dataContext.Quizzes.ToListAsync();
        }



        public async Task<Quiz?> GetQuizByIdAsync(int Id)
        {
            return await _dataContext.Quizzes.FindAsync(Id);
        }

        public async Task<Quiz?> UpdateQuizAsync(int quizId, Quiz quiz)
        {
            if (quizId == quiz.Id)
            {
                var existingQuiz = await _dataContext.Quizzes.FindAsync(quizId);
                if (existingQuiz != null)
                {
                    var correctAnswerCount = await _dataContext.UserAnswers
                        .CountAsync(a => a.QuizId == quizId && a.Answer.IsCorrect);

                    var totalQuestionCount = await _dataContext.UserAnswers
                        .Where(a => a.QuizId == quizId)
                        .Select(a => a.Answer.QuestionId)
                        .Distinct()
                        .CountAsync();
                    existingQuiz.EndTime = quiz.EndTime;
                    existingQuiz.UserAnswersCountCorrect = correctAnswerCount;
                    existingQuiz.UserAnswersCount = totalQuestionCount;

                    await _dataContext.SaveChangesAsync();
                    return existingQuiz;
                }
            }
            return null;
        }
    }
}
