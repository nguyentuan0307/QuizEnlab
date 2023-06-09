﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizEnlab.Data
{
    [Table("Quiz")]
    public class Quiz
    {
        public Quiz()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsPassed { get; set; }
        public int UserAnswersCountCorrect { get; set; }
        public int UserAnswersCount { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
