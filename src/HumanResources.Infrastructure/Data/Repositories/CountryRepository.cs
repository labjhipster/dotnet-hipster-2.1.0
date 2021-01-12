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
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(IUnitOfWork context) : base(context)
        {
        }

        public override async Task<Country> CreateOrUpdateAsync(Country country)
        {
            bool exists = await Exists(x => x.Id == country.Id);

            if (country.Id != 0 && exists)
            {
                Update(country);
            }
            else
            {
                _context.AddOrUpdateGraph(country);
            }
            return country;
        }
    }
}
