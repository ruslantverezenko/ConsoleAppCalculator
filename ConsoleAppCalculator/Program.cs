using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string userSelection;
            for(; ;)
            {
                Calculator();
                Console.Write("Continue calculations? (y - yes, n - no): ");
                userSelection = Console.ReadLine();
                if(userSelection == "y" || userSelection == "yes")
                {
                    continue;
                    
                }
                else if(userSelection == "n" || userSelection =="no")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

        }
        static void Calculator()
        {
            Console.Clear();
            Console.Write("Enter a number(for example 4,5): ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter a number(for example 9,8): ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the operator(+,-,*,/): ");
            string operatorCalculation = Console.ReadLine();

            if (operatorCalculation == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (operatorCalculation == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (operatorCalculation == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (operatorCalculation == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("The program didn't understand you");
            }
        }
    }
}
