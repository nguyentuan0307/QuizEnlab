using Microsoft.AspNetCore.Mvc;
using QuizEnlab.Model;
using QuizEnlab.Repositories.IRepository;

namespace QuizEnlab.Services.IServices
{
    public interface IAnswerService
    {
        public Task<ActionResult<bool?>> CheckAnswer(int QuestionId, AnswerModel answerModel);
    }
}
