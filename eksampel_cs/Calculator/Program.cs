using System;

namespace Calculator
{
     class Calculator
     {
          double Add(double a, double b)
          {
               return a + b;
          }
          double Subtract(double a, double b)
          {
               return a - b;
          }
          double Multiply(double a, double b)
          {
               return a * b;
          }
          double Power(double x, double exp)
          {
               return Math.Pow(x,exp);
          }

     }

}
