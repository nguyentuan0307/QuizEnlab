namespace QuizEnlab.Model
{
    public class QAViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
