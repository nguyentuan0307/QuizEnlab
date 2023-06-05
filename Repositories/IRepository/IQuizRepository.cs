using QuizEnlab.Data;

namespace QuizEnlab.Repositories.IRepository
{
    public interface IQuizRepository
    {
        public Task<Quiz?> CreateQuizAsync(Quiz quiz);
        public Task<Quiz?> GetQuizByIdAsync(int Id);
        public Task<Quiz?> UpdateQuizAsync(int quizId, Quiz quiz);
        public Task<List<Quiz>> GetAllQuizsAsync();
        public Task<Quiz?> UpdateQuizByIdAsync(int quizId);
    }
}
