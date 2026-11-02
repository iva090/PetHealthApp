using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Data.Exceptions
{
    public class VetException : Exception
    {
        public VetException()
        {
        }

        public VetException(string message) : base(message)
        {
        }

        public VetException(string message, Exception Ex) : base(message, Ex)
        {

        }
    }
}
