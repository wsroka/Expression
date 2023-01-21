using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    public interface IExpression
    {
        void Print();
        double Calculate();
    }
}
