using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizEnlab.Data
{
    [Table("UserAnswer")]
    public class UserAnswer
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public int AnswerIdSelected { get; set; }
        public Quiz Quiz { get; set; }
        public Answer Answer { get; set; }
    }
}
