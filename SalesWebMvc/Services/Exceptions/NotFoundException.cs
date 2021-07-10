using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        //Excessão personalizada
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
