using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Core.DTO.Request;
using TutorEase.Core.DTO.Response;
using TutorEase.Domain.Common;

namespace TutorEase.Core.Contract
{
    public interface ITutorService
    {
        Task<Response<AddTutorResponse>> AddTutor(AddTutorRequest request);
        Task<Response<List<AddTutorResponse>>> GetAllTutor();
        Task<Response<AddTutorResponse>> GetTutor();
        Task<Response<AddTutorResponse>> GetById(string id);
        Task<string> SoftDeletePayer(string id);
        Task<Response<AddTutorResponse>> UpdateTutor(UpdateTutorRequest request);
    }
}
