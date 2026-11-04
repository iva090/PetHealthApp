using PetHealth.Data.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Business.Exceptions
{
    public class NotFoundException : VetException
    {
        public NotFoundException(string message) : base(message) { }
    }
}
