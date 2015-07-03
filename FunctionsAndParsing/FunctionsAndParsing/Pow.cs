﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndParsing
{
    class Pow : CommonFunction
    {
        public List<CommonFunction> baseAndPower;

        public Pow() { baseAndPower = new List<CommonFunction>(); }

        public Pow(List<CommonFunction> baseAndPower)
        {
            this.baseAndPower = baseAndPower;
        }

        private double compute(double[] p)
        {
            if (baseAndPower.Count == 1) return baseAndPower[0].getFunction()(p)[0];
            else
            {
                double result = baseAndPower[baseAndPower.Count - 1].getFunction()(p)[0];
                for (int i = baseAndPower.Count - 2; i >= 0; i--)
                {
                    result = Math.Pow(baseAndPower[i].getFunction()(p)[0], result);
                }
                return result;
            }
        }

        public override Func<double[], double> getCommonFunction()
        {
            return p => compute(p);
        }
    }
}