using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using HumanResources.Domain;

namespace HumanResources.Domain.Services.Interfaces
{
    public interface IRegionService
    {
        Task<Region> Save(Region region);

        Task<IPage<Region>> FindAll(IPageable pageable);

        Task<Region> FindOne(long id);

        Task Delete(long id);
    }
}
