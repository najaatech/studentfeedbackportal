namespace StudentFeedback.API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public List<Feedback>? Feedbacks { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
    }
}