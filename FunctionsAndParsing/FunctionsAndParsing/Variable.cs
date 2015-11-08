using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndParsing
{
    public class Variable : CommonFunction
    {
        public int index;

        public Variable(int index)
        {
            this.index = index;
        }

        public override Func<double[], double> getCommonFunction()
        {
            return p => p[index];
        }
    }
}
