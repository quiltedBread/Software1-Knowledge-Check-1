using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            int num1;
            int num2;


            switch (input)
            {
                case "1":
                    if (Calculator.GetNumbers("add", out num1, out num2))
                    {
                        Console.Write($"{num1} + {num2} = ");
                        Console.Write(calculator.Add(num1, num2));
                    }
                    break;

                case "2":
                    if (Calculator.GetNumbers("subtract", out num1, out num2))
                    {
                        Console.Write($"{num1} - {num2} = ");
                        Console.Write(calculator.Subtract(num1, num2));
                    }
                    break;

                case "3":
                    if (Calculator.GetNumbers("multiply", out num1, out num2))
                    {
                        Console.Write($"{num1} * {num2} = ");
                        Console.Write(calculator.Multiply(num1, num2));
                    }
                    break;

                case "4":
                    if (Calculator.GetNumbers("divide", out num1, out num2))
                    {
                        Console.Write($"{num1} / {num2} = ");
                        Console.Write(calculator.Divide(num1, num2));
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}