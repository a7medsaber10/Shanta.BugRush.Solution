using Shanta.Core.Entities;
using Shanta.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Core.Repository.Contract
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllWithSpecAsync(ISpecification<T> specification);
        Task<T> GetWithSpecAsync(ISpecification<T> specification);
        Task<int> GetCountAsync(ISpecification<T> specification);
 
    }
}
