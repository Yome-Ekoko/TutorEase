using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Domain.Entities;

namespace TutorEase.Core.Contract.Repository
{
    public interface ITutorRepository
    {
        Task<List<Tutor>> GetAll();
        Task<Tutor> GetById(string id);
        Task<Tutor> Add(Tutor tutor);
        Task<Tutor> Update(Tutor tutor);
        Task Delete(string id);
        Task<Tutor> GetTutor();
    }
}
