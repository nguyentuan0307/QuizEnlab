using Microsoft.EntityFrameworkCore;

namespace QuizEnlab.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasOne(u => u.Question)
                .WithMany(x => x.Answers)
                .HasForeignKey(u => u.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserAnswer>()
                .HasOne(u => u.Quiz)
                .WithMany(x => x.UserAnswers)
                .HasForeignKey(u => u.QuizId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserAnswer>()
                .HasOne(u => u.Answer)
                .WithMany(x => x.UserAnswers)
                .HasForeignKey(u => u.AnswerIdSelected)
                .OnDelete(DeleteBehavior.Restrict);


            var questions = new List<Question>
            {
                new Question{Id=1, Text = "Câu hỏi 1"},
                new Question{Id=2, Text = "Câu hỏi 2"},
                new Question{Id=3, Text = "Câu hỏi 3"},
                new Question{Id=4, Text = "Câu hỏi 4"},
                new Question{Id=5, Text = "Câu hỏi 5"},
                new Question{Id=6, Text = "Câu hỏi 6"},
                new Question{Id=7, Text = "Câu hỏi 7"},
                new Question{Id=8, Text = "Câu hỏi 8"},
                new Question{Id=9, Text = "Câu hỏi 9"},
                new Question{Id=10, Text = "Câu hỏi 10"},
            };
            var answers = new List<Answer>
            {
                new Answer{Id=1, QuestionId = 1, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=2, QuestionId = 1, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=3, QuestionId = 1, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=4, QuestionId = 1, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=5, QuestionId = 2, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=6, QuestionId = 2, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=7, QuestionId = 2, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=8, QuestionId = 2, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=9, QuestionId = 3, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=10, QuestionId = 3, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=11, QuestionId = 3, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=12, QuestionId = 3, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=13, QuestionId = 4, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=14, QuestionId = 4, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=15, QuestionId = 4, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=16, QuestionId = 4, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=17, QuestionId = 5, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=18, QuestionId = 5, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=19, QuestionId = 5, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=20, QuestionId = 5, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=21, QuestionId = 6, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=22, QuestionId = 6, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=23, QuestionId = 6, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=24, QuestionId = 6, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=25, QuestionId = 7, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=26, QuestionId = 7, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=27, QuestionId = 7, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=28, QuestionId = 7, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=29, QuestionId = 8, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=30, QuestionId = 8, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=31, QuestionId = 8, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=32, QuestionId = 8, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=33, QuestionId = 9, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=34, QuestionId = 9, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=35, QuestionId = 9, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=36, QuestionId = 9, Text = "Đáp án 4", IsCorrect = false},
                new Answer{Id=37, QuestionId = 10, Text = "Đáp án 1", IsCorrect = true},
                new Answer{Id=38, QuestionId = 10, Text = "Đáp án 2", IsCorrect = false},
                new Answer{Id=39, QuestionId = 10, Text = "Đáp án 3", IsCorrect = false},
                new Answer{Id=40, QuestionId = 10, Text = "Đáp án 4", IsCorrect = false},
            };
            modelBuilder.Entity<Question>().HasData(questions);
            modelBuilder.Entity<Answer>().HasData(answers);
        }
    }
}
