using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Lesson_1_SimpleExceptionHandling
    {
        public static string DivideByZeroExceptionMsg = "You are trying to divide by zero";
        public static string ZeroDivideExceptionMsg = "You are trying to divide zero";
        private static string _welcomeMessage = "Welcome to my app";
        private static string _inputRequestTxt = "Type value: ";

        public void ExampleWithoutExceptionHandling()
        {
            float? result = null;

            Console.WriteLine(_welcomeMessage);

            do
            {
                Console.WriteLine($"{_inputRequestTxt} A");
                int valueA = int.Parse(Console.ReadLine());

                Console.WriteLine($"{_inputRequestTxt} B");
                int valueB = int.Parse(Console.ReadLine());

                result = DivideTwoNumbers(valueA, valueB);
                Console.WriteLine(result);
            } while (result == null);
        }

        public void ExampleWithExceptionHandling()
        {
            Console.WriteLine(_welcomeMessage);

            float? result = null;

            do
            {
                try
                {
                    Console.WriteLine($"{_inputRequestTxt} A");
                    int valueA = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{_inputRequestTxt} B");
                    int valueB = int.Parse(Console.ReadLine());

                    result = DivideTwoNumbers(valueA, valueB);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine($"Try one more time");
                }
            }
            while (result == null);
        }

        public float DivideTwoNumbers(float x, float y)
        {
            if (y == 0) throw new DivideByZeroException(DivideByZeroExceptionMsg);
            else if (x == 0) throw new Exception(ZeroDivideExceptionMsg);
            return x / y;
        }
    }
}
