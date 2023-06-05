using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizEnlab.Model;
using QuizEnlab.Services;
using QuizEnlab.Services.IServices;

namespace QuizEnlab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;
        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet("GetAllResult")]
        public async Task<ActionResult<List<ResultModel>>> GetAllResult()
        {
            var results = await _quizService.GetAllQuizAsync();
            return Ok(results);
        }
        [HttpGet("GetDetailResult")]
        public async Task<ActionResult<List<QAReviewModel>>> GetDetailResult(int quizId)
        {
            var results = await _quizService.GetDetailResult(quizId);
            return Ok(results);
        }

    }
}
