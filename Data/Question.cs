using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizEnlab.Data
{
    [Table("Question")]
    public class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer> { };
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public HashSet<Answer> Answers { get; set; }
    }
}
