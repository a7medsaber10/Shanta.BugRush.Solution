using Microsoft.EntityFrameworkCore;
using Shanta.Core.Entities;
using Shanta.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shanta.Repository.SpecificationEvaluator
{
    public static class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> innerQuery, ISpecification<TEntity> specification)
        {
            var query = innerQuery; // dbContext.Set<T>

            if (specification.Criteria is not null)
            {
                query = query.Where(specification.Criteria); // dbContext.Set<T>.Where( criteria )
            }

            if (specification.OrderBy is not null)
            {
                query = query.OrderBy(specification.OrderBy);
            }
            else if (specification.OrderByDesc is not null)
            {
                query = query.OrderByDescending(specification.OrderByDesc);
            }

            if (specification.IsPaginationEnabled)
            {
                query = query.Skip(specification.Skip).Take(specification.Take);
            }

            // since we don't know number of Includes => [ Aggregate Operator ]
            query = specification.Includes.Aggregate(query, (currentQuery, includesExpression) => currentQuery.Include(includesExpression));

            return query;
        }
    }
}
