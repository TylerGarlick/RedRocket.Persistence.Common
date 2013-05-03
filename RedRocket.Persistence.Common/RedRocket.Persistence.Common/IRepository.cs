using System.Collections.Generic;
using RedRocket.Persistence.Common.Validation;

namespace RedRocket.Persistence.Common
{
    public interface IRepository<T> : IReadOnlyRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        
        IEnumerable<PersistenceValidationError> Validate(T entity);
    }
}