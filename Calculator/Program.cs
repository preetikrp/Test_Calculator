using System;

namespace Calculator
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }

    public class Calculator{
      public int  add(int num1, int num2){
        return num1 + num2;

        }

        public int sub(int num1, int num2){
            return num1 - num2;

        }
        public int multiply(int num1, int num2){
            return num1 * num2;
        }
        public int divide(int num1, int num2){
            return num1 / num2;
            
        }
    }
}
