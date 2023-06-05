namespace QuizEnlab.Model
{
    public class ResultModel
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int UserAnswersCountCorrect { get; set; }
        public int UserAnswersCount { get; set; }
    }
}
