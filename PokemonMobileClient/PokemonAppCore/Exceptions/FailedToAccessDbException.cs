using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAppCore.Exceptions
{
    public class FailedToAccessDbException : Exception
    {

        public FailedToAccessDbException(Exception e)
        {
            
        }
    }
}
