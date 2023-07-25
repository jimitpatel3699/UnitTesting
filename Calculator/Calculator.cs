using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator :IDisposable
    {
        public int Addition(int first, int second) 
        {
            return first + second;
        }
        public int Subtraction(int first, int second) 
        {
            return second - first;
        }
        public int Multiplication(int first, int second) 
        {
            return first * second; 
        }
        public float Divide(float first, float second)
        {
            if(second == 0)
            {
                throw new ArgumentException($"Divided by zero not possible");
            }
            return first / second; 
        }

        public void Dispose()
        {
           
        }
    }
}
