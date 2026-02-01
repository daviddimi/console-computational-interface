using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal result = 0;
            Console.WriteLine("--- Computational Interface ---");

            while (true)
            {
                int num1;
                while (true)
                {
                    Console.Write("Input the initial operand: ");
                    string input1 = Console.ReadLine();

                    if (int.TryParse(input1, out num1))
                        break;
                    Console.WriteLine("Invalid entry. Please provide a numerical value.");
                }

                Console.WriteLine();

                Console.WriteLine("The available set of binary operations is: ");
                Console.WriteLine("1. Sum (+)");
                Console.WriteLine("2. Difference (-)");
                Console.WriteLine("3. Product (*)");
                Console.WriteLine("4. Quotient (/)");
                Console.WriteLine("5. Remainder (%)");

                Console.Write("Designate the operator: ");
                string operationChoice = Console.ReadLine()?.ToLower();
                string[] validOptions = { "1", "2", "3", "4", "5", "+", "-", "*", "/", "%" };

                if (!validOptions.Contains(operationChoice))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please select a valid operator from the provided set.");
                    Console.WriteLine("Re-initializing computation sequence...\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine();

                int num2;
                while (true)
                {
                    Console.Write("Input the secondary operand: ");
                    string input2 = Console.ReadLine();

                    if (int.TryParse(input2, out num2))
                        break;
                    Console.WriteLine("Invalid entry. Please provide a numerical value.");
                }


                if (operationChoice == "1" || operationChoice == "plus" || operationChoice == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine($"The resulting value of {num1} + {num2} is {Math.Round(result, 2)}.\n");
                }
                else if (operationChoice == "2" || operationChoice == "minus" || operationChoice == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine($"The resulting value of {num1} - {num2} is {Math.Round(result, 2)}.\n");
                }
                else if (operationChoice == "3" || operationChoice == "multiply" || operationChoice == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine($"The resulting value of {num1} * {num2} is {result}.\n");
                }
                else if (operationChoice == "4" || operationChoice == "divide" || operationChoice == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Mathematical undefined state (Division by zero).\n");
                        continue;
                    }
                    result = (decimal)num1 / num2;
                    Console.WriteLine($"The resulting value of {num1} / {num2} is {Math.Round(result, 2)}.\n");
                }
                else if (operationChoice == "5" || operationChoice == "remainder" || operationChoice == "%")
                {
                    result = num1 % num2;
                    Console.WriteLine($"The resulting value of {num1} % {num2} is {result}.\n");
                }
                Console.Write("Commence a further iteration? (y/n): ");
                operationChoice = Console.ReadLine()?.ToLower();

                if (operationChoice == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Computation session terminated. Thank you for utilizing this interface.");
                    break;
                }
            }
        }
    }
}
