using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChooses = "yes";
            while (UserChooses == "yes")
            {
                Console.WriteLine("Enter first operator");
                string operator1 = Console.ReadLine();

                Console.WriteLine("Enter second operator");
                string operator2 = Console.ReadLine();

                Console.WriteLine("Enter first number");
                string num1 = Console.ReadLine();
                double number1 = Convert.ToDouble(num1);

                Console.WriteLine("Enter second number");
                string num2 = Console.ReadLine();
                double number2 = Convert.ToDouble(num2);

                Console.WriteLine("Enter third number");
                string num3 = Console.ReadLine();
                double number3 = Convert.ToDouble(num3);

                string operation = operator1;
                int i = 0;
                double result = 0;
                while (i < 2)
                {
                    if (operation == "+")
                    {
                        result = number1 + number2;
                    }

                    else if (operation == "-")
                    {
                        result = number1 - number2;
                    }

                    else if (operation == "/")
                    {
                        result = number1 / number2;
                    }

                    else if (operation == "*")
                    {
                        result = number1 * number2;
                    }

                    operation = operator2;
                    i++;
                    number1 = result;
                    number2 = number3;
                }

                    Console.WriteLine("The result is: " + result);

                Console.WriteLine("Another calculation? Enter yes or no.");
                UserChooses = Console.ReadLine();
            }
        }
    }
}
