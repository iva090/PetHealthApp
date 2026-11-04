using PetHealth.Data.Exceptions;

namespace PetHealth.Business.Exceptions
{
    public class ForbiddenException : VetException
    {
        public ForbiddenException(string message) : base(message) { }
    }
}
