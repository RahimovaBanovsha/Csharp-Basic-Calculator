using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Simple Calculator ===");

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            if (!double.TryParse(input1, out double number1))
            {
                Console.WriteLine("Invalid input for first number!");
                return;
            }

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            if (!double.TryParse(input2, out double number2))
            {
                Console.WriteLine("Invalid input for second number!");
                return;
            }

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");

            Console.WriteLine("Enter operator: ");
            string op=Console.ReadLine();
          
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result: {Add(number1, number2)}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {Subtract(number1, number2)}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {Multiply(number1, number2)}");
                    break;

                case "/":
                    if (number2 != 0)
                        Console.WriteLine($"Result: {Divide(number1, number2)}");
                    else
                        Console.WriteLine("Error: Cannot divide by zero.");
                    break;

                default:
                    Console.WriteLine("Invalid operation. Use +, -, *, or /.");
                    break;
            }
        }

        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => a / b;
    
    }
}