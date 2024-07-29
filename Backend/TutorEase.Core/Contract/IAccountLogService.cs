using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Common;
using TutorEase.Domain.QueryParameters;

namespace TutorEase.Core.Contract
{
    public interface IAccountLogService
    {
        Task<byte[]> DownloadLogs(DownloadLogsRequest request, CancellationToken cancellationToken);
        Task<PagedResponse<List<AccountLogResponse>>> GetLogs(LogQueryParameters queryParameters, CancellationToken cancellationToken);
        Task<Response<AccountLogResponse>> GetLogById(long id, CancellationToken cancellationToken);
    }
}
