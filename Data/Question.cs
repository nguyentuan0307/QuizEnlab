using QuizEnlab.Model;
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
        public ICollection<Answer> Answers { get; set; }

        public static implicit operator Question(QAViewModel v)
        {
            throw new NotImplementedException();
        }
    }

}
