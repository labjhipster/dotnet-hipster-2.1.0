using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using HumanResources.Domain;

namespace HumanResources.Domain.Services.Interfaces
{
    public interface ILocationService
    {
        Task<Location> Save(Location location);

        Task<IPage<Location>> FindAll(IPageable pageable);

        Task<Location> FindOne(long id);

        Task Delete(long id);
    }
}
