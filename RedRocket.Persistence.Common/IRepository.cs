using System.Collections.Generic;
using RedRocket.Utilities.Core.Validation;

namespace RedRocket.Persistence.Common
{
    public partial interface IRepository<T> : IReadOnlyRepository<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        
        IEnumerable<ObjectValidationError> Validate(T entity);
    }
}