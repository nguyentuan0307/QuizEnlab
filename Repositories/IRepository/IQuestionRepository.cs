using QuizEnlab.Data;
using QuizEnlab.Model;

namespace QuizEnlab.Repositories.IRepository
{
    public interface IQuestionRepository
    {
        public Task<Question?> GetQuestionById(int id);
        public Task<QAViewModel?> GetRandomQuestionAsync();
        public Task<QAViewModel?> GetRandomQuestionExcludingAsync(HashSet<int> usedQuestionIds);
        public Task<int?> GetIdQuestionByIdAnswerAsync(int answerId);
        public Task<List<Question>?> GetQuestionsByQuizAsync(int quizId);
    }
}
