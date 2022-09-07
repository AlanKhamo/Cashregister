using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_new
{
     public class Calculator_new
     {
          public double Add(double a, double b)
          {
               return a + b;
          }
          public double Subtract(double a, double b)
          {
               return a - b;
          }
          public double Multiply(double a, double b)
          {
               return a * b;
          }
          public double Power(double x, double exp)
          {
               return Math.Pow(x, exp);
          }
     }
}
