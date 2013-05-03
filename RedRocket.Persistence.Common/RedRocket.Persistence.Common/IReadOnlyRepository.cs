using System;
using System.Linq;
using System.Linq.Expressions;

namespace RedRocket.Persistence.Common
{
    public interface IReadOnlyRepository<T> where T : class
    {
        IQueryable<T> All();
        IQueryable<T> Query(Func<T, bool> predicate);
        T FindWithKey(Expression<Func<T, bool>> predicate);
    }
}