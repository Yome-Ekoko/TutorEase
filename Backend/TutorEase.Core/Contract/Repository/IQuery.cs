using TutorEase.Persistence;

namespace TutorEase.Core.Contract.Repository
{
    public interface IQuery<TOut>
    {
        IQueryable<TOut> Run(ApplicationDbContext dbContext);
    }
}
