using System;
using System.Collections.Generic;

namespace RedRocket.Persistence.Common.Validation
{
    /// <summary>
    /// Exception Helper for DbEntityValidationResult
    /// </summary>
    public class PersistenceValidationException : Exception
    {
        public IEnumerable<PersistenceValidationError> Errors { get; private set; }
        public PersistenceValidationException(IEnumerable<PersistenceValidationError> errors)
        {
            Errors = errors;
        }
    }
}