using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This exception is to be thrown in case it is attempted
    // to withdraw or deposit a negative amount
    class NegativeAmountException : Exception
    {
    }
}
