


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace SimpleCalculatorMVC.Logic
{

    public class SimpleCalculator
    {

        public static void BasicCalculator()
        {

            Console.WriteLine("Welcome to the Basic Calculator!");


            while (true)
            {
                Console.WriteLine("\nEnter the operation (+, -, *, /) or 'q' to quit:");
                
                char operation = Console.ReadLine()[0];

                if (operation == 'q')
                {
                    break;
                }


                Console.WriteLine("Enter the first number:");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = double.Parse(Console.ReadLine());


                double result = 0;


                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;


                    case '-':
                        result = num1 - num2;
                        break;


                    case '*':
                        result = num1 * num2;
                        break;


                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }

                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero!");
                        }

                        break;


                    default:
                        Console.WriteLine("Error: Invalid operation!");
                        break;
                
                }


                Console.WriteLine($"Result: {result}");

            }

            Console.WriteLine("Thank you for using the Simple Calculator!");
        
        }
    }
}



