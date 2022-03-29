using System;
using System.Collections.Generic;
using System.Text;

namespace unitask043.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
