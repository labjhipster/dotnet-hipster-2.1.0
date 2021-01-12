using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JHipsterNet.Core.Pagination;
using JHipsterNet.Core.Pagination.Extensions;
using HumanResources.Domain;
using HumanResources.Domain.Repositories.Interfaces;
using HumanResources.Infrastructure.Data.Extensions;

namespace HumanResources.Infrastructure.Data.Repositories
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(IUnitOfWork context) : base(context)
        {
        }

        public override async Task<Region> CreateOrUpdateAsync(Region region)
        {
            bool exists = await Exists(x => x.Id == region.Id);

            if (region.Id != 0 && exists)
            {
                Update(region);
            }
            else
            {
                _context.AddOrUpdateGraph(region);
            }
            return region;
        }
    }
}
