using StudentFeedback.API.Models;

namespace StudentFeedback.API.Repositories
{
    public interface IFeedbackRepository
    {
        Task<Feedback?> GetFeedbackAsync(int studentId, int courseId);
        Task AddFeedbackAsync(Feedback feedback);
        Task<bool> IsStudentEnrolledAsync(int studentId, int courseId);
        Task<List<Feedback>> GetAllFeedbackAsync();
        Task SaveChangesAsync();
    }
}