using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        /// <summary>
        /// Requests two inputs for a specific numerical operation, then parses inputs to integers.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>true if inputs were valid integers, else false</returns>
        public static bool GetNumbers(string operation, out int num1, out int num2)
        {

            Console.WriteLine($"Enter 2 integers to {operation}");
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                return true;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                num1 = 0;
                num2 = 0;
                return false;
            }

        }
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
