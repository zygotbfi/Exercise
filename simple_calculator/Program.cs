using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result, operation;
            Console.WriteLine("-----------------------");
            Console.WriteLine("*  Simple Calculator  *");
            Console.WriteLine("-----------------------");
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Choose an operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
            Console.Write("Enter the operation number (1-4): ");
            operation = Convert.ToDouble(Console.ReadLine());
            result = 0;
            if (operation < 1 || operation > 4)
            {
                Console.WriteLine("Invalid operation number");
                return;
            }

            if (operation == 1)
            {
                Program p = new Program();
                result = p.Add(num1, num2);
                Console.WriteLine();
                Console.WriteLine("Result of Addition: " + result);
            }
            if (operation == 2)
            {
                Program p = new Program();
                result = p.Subtract(num1, num2);
                Console.WriteLine();
                Console.WriteLine("Result of Subtraction: " + result);
            }
            if (operation == 3)
            {
                Program p = new Program();
                result = p.Multiply(num1, num2);
                Console.WriteLine();
                Console.WriteLine("Result of Multiplication: " + result);
            }
            if (operation == 4)
            {
                try
                {
                    if (num2 == 0)
                    {
                        throw new Exception("Cannot be Divided by zero");
                    }
                    Program p = new Program();
                    result = p.Divide(num1, num2);
                    Console.WriteLine();
                    Console.WriteLine("Result of Division: " + result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }

}