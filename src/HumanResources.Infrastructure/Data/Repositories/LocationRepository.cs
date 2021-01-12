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
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(IUnitOfWork context) : base(context)
        {
        }

        public override async Task<Location> CreateOrUpdateAsync(Location location)
        {
            bool exists = await Exists(x => x.Id == location.Id);

            if (location.Id != 0 && exists)
            {
                Update(location);
            }
            else
            {
                _context.AddOrUpdateGraph(location);
            }
            return location;
        }
    }
}
