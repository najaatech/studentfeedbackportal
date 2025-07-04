using Microsoft.EntityFrameworkCore;

namespace StudentFeedback.API.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public List<Feedback>? Feedbacks { get; set; }
        public List<Enrollment>? Enrollments { get; set; }
    }
}