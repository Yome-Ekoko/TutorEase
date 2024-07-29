using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Common;
using TutorEase.Domain.QueryParameters;

namespace TutorEase.Core.Contract
{
    public interface IFundLogService
    {
        Task<byte[]> DownloadLogs(DownloadLogsRequest request, CancellationToken cancellationToken);
        Task<PagedResponse<List<FundLogResponse>>> GetLogs(LogQueryParameters queryParameters, CancellationToken cancellationToken);
        Task<Response<FundLogResponse>> GetLogById(long id, CancellationToken cancellationToken);
    }
}
