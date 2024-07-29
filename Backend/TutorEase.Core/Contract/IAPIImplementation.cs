using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;

namespace TutorEase.Core.Contract
{
    public interface IAPIImplementation
    {
        Task<SendMailResponse> SendMail(SendMailRequest request);
    }
}
