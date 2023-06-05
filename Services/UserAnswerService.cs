using QuizEnlab.Data;
using QuizEnlab.Repositories.IRepository;
using QuizEnlab.Services.IServices;

namespace QuizEnlab.Services
{
    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IQuizRepository _quizRepository;
        public UserAnswerService(IUserAnswerRepository userAnswerRepository, IQuizRepository quizRepository)
        {
            _userAnswerRepository = userAnswerRepository;
            _quizRepository = quizRepository;
        }
        public async Task<UserAnswer?> SaveUserAnswerAsync(int quizId, int answerIdSelected)
        {
            var quiz = await _quizRepository.GetQuizByIdAsync(quizId);
            if (quiz == null)
            {
                return null;
            }

            var userAnswer = new UserAnswer
            {
                QuizId = quizId,
                AnswerIdSelected = answerIdSelected
            };

            return await _userAnswerRepository.SaveUserAnswerAsync(userAnswer);
        }
    }
}
