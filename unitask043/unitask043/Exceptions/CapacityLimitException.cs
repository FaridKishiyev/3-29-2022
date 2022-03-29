using System;
using System.Collections.Generic;
using System.Text;

namespace unitask043.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base( message)
        {

        }
    }
}
