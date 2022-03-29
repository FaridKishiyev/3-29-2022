using System;
using System.Collections.Generic;
using System.Text;

namespace unitask043.Exceptions
{
    class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message)
        {

        }
    }
}
