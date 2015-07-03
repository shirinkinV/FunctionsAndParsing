using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndParsing
{
    interface Function
    {
        Func<double[], double[]> getFunction();
    }
}
