using QuizEnlab.Data;

namespace QuizEnlab.Model
{
    public class QAModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
