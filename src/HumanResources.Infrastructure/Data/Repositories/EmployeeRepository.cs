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
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork context) : base(context)
        {
        }

        public override async Task<Employee> CreateOrUpdateAsync(Employee employee)
        {
            bool exists = await Exists(x => x.Id == employee.Id);

            if (employee.Id != 0 && exists)
            {
                Update(employee);
            }
            else
            {
                _context.AddOrUpdateGraph(employee);
            }
            return employee;
        }
    }
}
