using AutoMapper;
using QuizEnlab.Data;
using QuizEnlab.Model;
using QuizEnlab.Repositories.IRepository;
using QuizEnlab.Services.IServices;

namespace QuizEnlab.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;
        private readonly IQuestionRepository _questionRepository;
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly IMapper _mapper;

        public QuizService(IQuizRepository quizRepository, IQuestionRepository questionRepository, IUserAnswerRepository userAnswerRepository, IMapper mapper, IAnswerRepository answerRepository)
        {
            _quizRepository = quizRepository;
            _mapper = mapper;
            _questionRepository = questionRepository;
            _userAnswerRepository = userAnswerRepository;
            _answerRepository = answerRepository;
        }

        public async Task<ResultModel?> CreateQuizAsync()
        {
            var quiz = new Quiz
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now
            };

            return _mapper.Map<ResultModel>(await _quizRepository.CreateQuizAsync(quiz));
        }

        public async Task<List<ResultModel>?> GetAllQuizAsync()
        {
            var results = await _quizRepository.GetAllQuizsAsync();
            return _mapper.Map<List<ResultModel>>(results);

        }

        public async Task<List<QAReviewModel>?> GetDetailResult(int idQuiz)
        {
            var questions = await _questionRepository.GetQuestionsByQuizAsync(idQuiz);
            if (questions == null)
            {
                return null;
            }
            var result = new List<QAReviewModel>();
            foreach (var question in questions)
            {
                var idAnswerSelected = await _userAnswerRepository.GetAnswerReviewIdByQuestionsAsync(idQuiz, question);
                var answers = await _answerRepository.GetAnswersByQuestionAsync(question.Id);
                List<AnswerReviewModel> answerReviewModels = _mapper.Map<List<AnswerReviewModel>>(answers);
                result.Add(new QAReviewModel
                {
                    Id = question.Id,
                    Text = question.Text,
                    IdAnswerSelected = idAnswerSelected,
                    Answers = answerReviewModels
                });
            }
            return result;
        }

        public async Task<ResultModel?> QuizViewAsync(int id)
        {
            var quiz = _mapper.Map<ResultModel>(await _quizRepository.UpdateQuizByIdAsync(id));
            return quiz;
        }
    }
}
