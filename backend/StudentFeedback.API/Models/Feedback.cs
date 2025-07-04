namespace StudentFeedback.API.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}