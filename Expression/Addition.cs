using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    internal class Addition : IExpression
    {
        private readonly IExpression expression1;
        private readonly IExpression expression2;
        public Addition(IExpression expression1, IExpression expression2)
        {
            this.expression1 = expression1;
            this.expression2 = expression2;
        }
        public void Print()
        {
            Console.Write("(");
            expression1.Print();
            Console.Write(" + ");
            expression2.Print();
            Console.Write(")");
        }
        public double Calculate()
        {
            return expression1.Calculate() + expression2.Calculate();        
        }
    }
}
