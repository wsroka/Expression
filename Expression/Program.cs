
using Expression;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

IExpression stala5 = new Constant(5);
IExpression stala3 = new Constant(3);
IExpression zmiennaX = new Variable("X", 4);
IExpression zmiennaY = new Variable("Y", 7.5);
IExpression addition = new Addition(stala5, zmiennaY);
double additionResult = addition.Calculate();
IExpression multiplication = new Multiplication(stala3, zmiennaX);
double multiplcationResult = multiplication.Calculate();
IExpression result = new Subtraction(addition, multiplication);
result.Print(); // ((5 + Y) - (3 * X)) 
Console.WriteLine(" = {0}", result.Calculate());