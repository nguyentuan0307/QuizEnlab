namespace QuizEnlab.Model
{
    public class QAReviewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int IdAnswerSelected { get; set; }
        public List<AnswerReviewModel> Answers { get; set; }

        public static implicit operator List<object>(QAReviewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
