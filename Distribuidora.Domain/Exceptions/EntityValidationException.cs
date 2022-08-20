namespace Distribuidora.Domain.Exceptions
{
    internal class EntityValidationException: Exception
    {
        public EntityValidationException(string? message): base(message)
        {

        }
    }
}
