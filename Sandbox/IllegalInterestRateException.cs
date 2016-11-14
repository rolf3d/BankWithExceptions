using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This exception is to be thrown in case the bank account
    // is defined with an illegal interest rate
    class IllegalInterestRateException : Exception
    {
    }
}
