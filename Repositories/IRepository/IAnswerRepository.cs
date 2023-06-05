using QuizEnlab.Data;
using QuizEnlab.Model;

namespace QuizEnlab.Repositories.IRepository
{
    public interface IAnswerRepository
    {
        public Task<bool?> ValidateAnswersAsync(int id);
        public Task<List<Answer>?> GetAnswersByQuestionAsync(int QuestionId);
    }
}
