using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities;
using Shanta.Core.Repository.Contract;
using Shanta.Core.Specifications;
using Shanta.Repository.Data;
using Shanta.Repository.SpecificationEvaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _dbContext;

        public GenericRepository(StoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        private IQueryable<T> ApplySpecifications(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>(), specification);
        }

        public async Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification)
        {   
            return await ApplySpecifications(specification).ToListAsync();
        }

        public async Task<T> GetWithSpecAsync(ISpecification<T> specification)
        {
            return await ApplySpecifications(specification).FirstOrDefaultAsync();
        }

        public async Task<int> GetCountAsync(ISpecification<T> specification)
        {
            return await ApplySpecifications(specification).CountAsync();
        }
    }
}
