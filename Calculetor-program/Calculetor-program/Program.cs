using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculetor_program
{
    internal class Program
    {
        static void Main(string[] args)
        {         //Welcome to the calculator program           
            Console.WriteLine(" Hello, Wellcome to the calculator progra!");

            float number1, number2, result;
            String Answer;

            Console.Write(" Enter your First number :");
            number1 = int.Parse(Console.ReadLine());

            Console.Write(" Enter your Second number :");
            number2 = int.Parse(Console.ReadLine());

            Console.Write(" Choose the Arithmatic Operation :");
            Answer = Console.ReadLine();

            if (Answer == "+")
            {
                result = number1 + number2;
            }
            else if (Answer == "-")
            {
                result = number1 - number2;
            }
            else if (Answer == "*")
            {
                result = number1 * number2;
            }
            else
            {
                result = number1 / number2;
            }

            Console.WriteLine(" The result is : "+ result);
            Console.WriteLine(" Thank you for using the calculator Program .");

            Console.ReadLine();
        }
    }
}
