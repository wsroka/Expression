using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    internal class Constant : IExpression
    {
        private double constant;
        public Constant(double constant) 
        { 
        this.constant = constant;
        }
        public void Print()
        {
            Console.Write(constant);
        }
        public double Calculate()
        {
            return constant;
        }
    }

}
