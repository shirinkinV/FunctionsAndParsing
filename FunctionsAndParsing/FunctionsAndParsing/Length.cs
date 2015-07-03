﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndParsing
{
    class Length : CommonFunction
    {
        private VectorFunction arg;

        public Length(VectorFunction arg)
        {
            this.arg = arg;
        }

        static double length(double[] p)
        {
            double sum = 0;
            for (int i = 0; i < p.Length; i++)
            {
                sum += p[i] * p[i];
            }
            return Math.Sqrt(sum);
        }

        public override Func<double[], double> getCommonFunction()
        {
            return p => length(arg.getFunction()(p));
        }
    }
}
