using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;

namespace TutorEase.Core.Contract
{
    public interface INotificationService
    {
        Task SendPasswordResetToken(string userName, string url, string firstName, string email);
        Task<SendMailResponse> SendOtp(SendOtpRequest request);
        Task<SendMailResponse> SendWelcomeMail(WelcomeRequest request);
    }
}
