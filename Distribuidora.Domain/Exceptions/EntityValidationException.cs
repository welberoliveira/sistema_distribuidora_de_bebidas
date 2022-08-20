using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distribuidora.Domain.Exceptions
{
    internal class EntityValidationException: Exception
    {
        public EntityValidationException(string? message): base(message)
        {
        }
    }
}
