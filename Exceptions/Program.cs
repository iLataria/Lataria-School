using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Program
    {
        public static string DivideByZeroExceptionMsg = "You are trying to divide by zero";
        public static string ZeroDivideExceptionMsg = "You are trying to divide zero";
        
        static void Main(string[] args)
        {
            float result = DivideTwoNumbers(5,0);
            Console.WriteLine(result);
        }

        public static float DivideTwoNumbers(float x, float y)
        {
            if (y == 0) throw new DivideByZeroException(DivideByZeroExceptionMsg);
            else if(x == 0) throw new Exception(ZeroDivideExceptionMsg);
            return x / y;
        }
    }
}
