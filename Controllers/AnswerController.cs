using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizEnlab.Model;
using QuizEnlab.Services.IServices;
using System.Threading.Tasks;

namespace QuizEnlab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        private readonly IUserAnswerService _userAnswerService;
        public AnswerController(IAnswerService answerService, IUserAnswerService userAnswerService)
        {
            _answerService = answerService;
            _userAnswerService = userAnswerService;
        }

        [HttpPost("CheckAnswer")]
        public async Task<ActionResult<bool?>> CheckAnswer(int quizId, int questionId, AnswerModel answerModel)
        {
            var result = await _answerService.CheckAnswer(questionId, answerModel);
            await _userAnswerService.SaveUserAnswerAsync(quizId, answerModel.Id);
            return result;
        }
    }
}
