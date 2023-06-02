using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizEnlab.Data
{
    [Table("Answer")]
    public class Answer
    {
        public Answer()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public HashSet<UserAnswer> UserAnswers { get; set; }
    }
}
