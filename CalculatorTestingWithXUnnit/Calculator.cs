namespace CalculatorTestingWithXUnnit
{
    public class Calculator
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
            return (first *  second);
        }
        public int division(int first, int second) 
        {
            if(second == 0)
            {
                throw new ArgumentException("Divide by 0 not possible");
            }
            return first/second;
        }

    }
}