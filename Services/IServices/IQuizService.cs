using QuizEnlab.Data;
using QuizEnlab.Model;

namespace QuizEnlab.Services.IServices
{
    public interface IQuizService
    {
        public Task<ResultModel?> CreateQuizAsync();
        public Task<ResultModel?> GetQuizAsync(int id);
        public Task<List<ResultModel>?> GetAllQuizAsync();
        public Task<List<QAReviewModel>?> GetDetailResult(int id);
    }
}
