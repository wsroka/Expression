using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    internal class Variable : IExpression
    {
        private readonly string name;
        private double value;
        public Variable(string name, double value)
        {
            this.name = name;
            this.value = value;
        }
        public void Print()
        {
            Console.Write(name);
        }
        public double Calculate()
        {
            return value;
        }
    }
}
