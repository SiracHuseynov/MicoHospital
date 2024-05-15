using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationMicoHospital.Business.Exceptions
{
    public class FileContextTypeException : Exception
    {
        public FileContextTypeException(string? message) : base(message)
        {
        }
    }
}
