using Distribuidora.Domain.Exceptions;

namespace Distribuidora.Domain.Validation
{
    public class DomainValidation
    {
        public static void NotNull(Object? value, string fieldName)
        {
            if (value == null) throw new EntityValidationException($"{fieldName} should not be null");
        }

        public static void NotNullOrEmpty(string? value, string fildName)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new EntityValidationException($"{fildName} should not be null or empty");
        }
    }
}
