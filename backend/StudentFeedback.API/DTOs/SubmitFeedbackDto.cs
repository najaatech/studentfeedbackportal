namespace StudentFeedback.API.DTOs
{
    public class SubmitFeedbackDto
    {
        public int CourseId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
    }
}