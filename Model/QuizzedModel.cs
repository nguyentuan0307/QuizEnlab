using QuizEnlab.Data;

namespace QuizEnlab.Model
{
    public class QuizzedModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerReviewModel> Answers { get; set; }
    }
}
