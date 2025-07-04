using Microsoft.EntityFrameworkCore;
using StudentFeedback.API.DTOs;
using StudentFeedback.API.Models;

namespace StudentFeedback.API.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly AppDbContext _context;

        public FeedbackService(AppDbContext context)
        {
            _context = context;
        }

        public async Task SubmitFeedbackAsync(SubmitFeedbackDto dto, int studentId)
        {
            // Check if student is enrolled in the course (optional)
            var enrolled = await _context.Enrollments
                .AnyAsync(e => e.StudentId == studentId && e.CourseId == dto.CourseId);

            if (!enrolled)
                throw new Exception("Student is not enrolled in the course.");

            // Check if feedback already exists
            var existing = await _context.Feedback
                .FirstOrDefaultAsync(f => f.StudentId == studentId && f.CourseId == dto.CourseId);

            if (existing != null)
                throw new Exception("Feedback already submitted for this course.");

            var feedback = new Feedback
            {
                StudentId = studentId,
                CourseId = dto.CourseId,
                Rating = dto.Rating,
                Comment = dto.Comment,
                CreatedAt = DateTime.UtcNow
            };

            _context.Feedback.Add(feedback);
            await _context.SaveChangesAsync();
        }
    }
}
