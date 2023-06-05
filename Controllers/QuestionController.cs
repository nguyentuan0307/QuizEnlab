using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizEnlab.Model;
using QuizEnlab.Services.IServices;
using System.Threading.Tasks;

namespace QuizEnlab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IQuizService _quizService;
        public QuestionController(IQuestionService questionService, IQuizService quizService)
        {
            _questionService = questionService;
            _quizService = quizService;
        }

        [HttpGet("Start")]
        public async Task<ActionResult<QAViewModel>> GetFirstQuestion()
        {
            var quiz = await _quizService.CreateQuizAsync();
            QuestionModel? question = await _questionService.GetFirstQuestionAsync(quiz.Id);
            if (question == null)
            {
                return BadRequest();
            }

            return Ok(question);
        }

        [HttpGet("Next")]
        public async Task<ActionResult<QAViewModel>> GetNextQuestion(int quizId)
        {
            var questionResult = await _questionService.GetNextQuestionAsync(quizId);
            if (questionResult == null)
            {
                return BadRequest();
            }
            if (!questionResult.IsQuiz)
            {
                return BadRequest("Invalid quiz ID");
            }
            if (!questionResult.IsQuestion)
            {
                var resultModel = questionResult.ResultModel;
                if (resultModel == null)
                {
                    return BadRequest();
                }
                var response = new
                {
                    Text = "Question is Over",
                    Data = resultModel
                };
                return Ok(response);
            }
            return Ok(questionResult.Question);
        }
        [HttpGet("GetAllQuestions")]
        public async Task<ActionResult<QuestionsModel>> GetAllQuestions()
        {
            var quiz = await _quizService.CreateQuizAsync();
            var questions = await _questionService.GetQuestionsAsync(quiz.Id);
            if (questions == null)
            {
                return BadRequest();
            }

            return Ok(questions);
        }
        [HttpGet("End")]
        public async Task<ActionResult<ResultModel>> EndQuiz(int quizId)
        {
            var quiz = await _quizService.QuizViewAsync(quizId);
            if (quiz == null)
            {
                return BadRequest();
            }
            return Ok(quiz);
        }
    }
}
