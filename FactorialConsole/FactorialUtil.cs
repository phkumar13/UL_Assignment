using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialConsole;

public static class FactorialUtil
{
    public static long GetFactorial(long x)
    {
        if (x <= 1)
            return 1;
        else
        {
            long xMin1Fact = GetFactorial(x - 1);
            long result = x * xMin1Fact;

            if (result < 0)
            {
                throw new FactorialException();
            }
            else
            {
                return x * GetFactorial(x - 1);
            }
        }
    }
}
