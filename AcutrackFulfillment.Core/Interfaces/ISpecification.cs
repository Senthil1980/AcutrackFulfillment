using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AcutrackFulfillment.Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        Expression<Func<T, object>> GroupBy { get; }

        String CacheKey { get; }

        int Take { get; }
        int Skip { get; }
        bool isPagingEnabled { get;}
    }
}
