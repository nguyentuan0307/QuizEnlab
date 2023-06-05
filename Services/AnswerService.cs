using QuizEnlab.Model;
using QuizEnlab.Repositories.IRepository;
using QuizEnlab.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace QuizEnlab.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;

        public AnswerService(IAnswerRepository answerRepository, IQuestionRepository questionRepository)
        {
            _answerRepository = answerRepository;
            _questionRepository = questionRepository;
        }

        public async Task<ActionResult<bool?>> CheckAnswer(int questionId, AnswerModel answerModel)
        {
            var questionIdAnswerTask = _questionRepository.GetIdQuestionByIdAnswerAsync(answerModel.Id);
            var questionIdAnswer = await questionIdAnswerTask;

            if (questionIdAnswer != questionId)
            {
                return new BadRequestObjectResult("Invalid question ID");
            }

            var isCorrect = await _answerRepository.ValidateAnswersAsync(answerModel.Id);
            if (isCorrect == null)
            {
                return new NotFoundObjectResult("Answer not found");
            }

            return isCorrect;
        }
    }
}
