using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorEase.Domain.Entities;

namespace TutorEase.Core.Contract.Repository
{
    public interface IScheduleRepository
    {
        Task<List<Schedule>> GetAll();
        Task<Schedule> GetById(string id);
        Task<List<Schedule>> GetByUserId(string userId);
        Task<Schedule> Add(Schedule schedule);
        Task<Schedule> Update(Schedule schedule);
        Task Delete(string id);
        Task<List<Tutor>> GetAllTutorScheduleAsync(string tutorId, string day, string time, string time1);
    }
}
