using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Common;
using TutorEase.Domain.QueryParameters;

namespace TutorEase.Core.Contract
{
    public interface IWithdrawLogService
    {
        Task<byte[]> DownloadLogs(DownloadLogsRequest request, CancellationToken cancellationToken);
        Task<PagedResponse<List<WithdrawLogResponse>>> GetLogs(LogQueryParameters queryParameters, CancellationToken cancellationToken);
        Task<Response<WithdrawLogResponse>> GetLogById(long id, CancellationToken cancellationToken);
    }
}
