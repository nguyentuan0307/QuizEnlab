using Microsoft.EntityFrameworkCore;
using QuizEnlab.Data;
using QuizEnlab.Repositories.IRepository;

namespace QuizEnlab.Repositories
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly DataContext _dataContext;
        public AnswerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Answer>?> GetAnswersByQuestionAsync(int questionId)
        {
            var question = await _dataContext.Questions
                .Include(q => q.Answers)
                .FirstOrDefaultAsync(q => q.Id == questionId);

            if (question != null)
            {
                return question.Answers.ToList();
            }

            return null;
        }

        public async Task<bool?> ValidateAnswersAsync(int id)
        {
            var answer = await _dataContext.Answers.FirstOrDefaultAsync(a => a.Id == id);
            if (answer == null)
            {
                return null;
            }
            return answer.IsCorrect;
        }
    }
}
