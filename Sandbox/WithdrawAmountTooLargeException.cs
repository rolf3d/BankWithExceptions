using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    // This exception is to be thrown in case it is attempted
    // to withdraw an amount larger than the current balance
    class WithdrawAmountTooLargeException : Exception
    {
    }
}
