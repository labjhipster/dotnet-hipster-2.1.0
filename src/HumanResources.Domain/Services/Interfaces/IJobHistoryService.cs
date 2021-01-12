using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using HumanResources.Domain;

namespace HumanResources.Domain.Services.Interfaces
{
    public interface IJobHistoryService
    {
        Task<JobHistory> Save(JobHistory jobHistory);

        Task<IPage<JobHistory>> FindAll(IPageable pageable);

        Task<JobHistory> FindOne(long id);

        Task Delete(long id);
    }
}
