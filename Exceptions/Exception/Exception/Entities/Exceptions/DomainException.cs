using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }


    }
}
