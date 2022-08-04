using System;
using System.Text;

namespace ConsoleApp1
{
    enum Operators
    {
        Add = 1,
        Subtract,
        Multiple,
        Divide,
        Exit
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\tCalculator");

            bool start = true;

            while (start)
            {
                float a, b, sum = 0;
                int choice;

                Console.WriteLine("1->Add\n2->Subtarct\n3->Divide\n4->Multiple:");
                int.TryParse(Console.ReadLine(), out choice);

                Console.WriteLine("Enter first number: ");
                float.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Enter second number: ");
                float.TryParse(Console.ReadLine(), out b);

                Console.Clear();

                switch ((Operators)choice)
                {
                    case Operators.Add:
                        {
                            sum = Add(a, b);
                            Console.WriteLine($"\nSum: {a} + {b} = {sum}\n\n");
                            break;
                        }
                    case Operators.Subtract:
                        {
                            sum = Subtract(a, b);
                            Console.WriteLine($"\nSum: {a} - {b} = {sum}\n\n");
                            break;
                        }
                    case Operators.Multiple:
                        {
                            sum = Multpile(a, b);
                            Console.WriteLine($"\nSum: {a} * {b} = {sum}\n\n");
                            break;
                        }
                    case Operators.Divide:
                        {
                            sum = Divide(a, b);
                            Console.WriteLine($"\nSum: {a} / {b} = {sum}\n\n");
                            break;
                        }
                    case Operators.Exit:
                        {
                            start = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nOnly have 4 choices!!!(1-4)");
                            break;
                        }
                }

                static float Add(float a, float b)
                {
                    float sum = a + b;
                    return sum;
                }

                static float Subtract(float a, float b)
                {
                    float sum = a - b;
                    return sum;
                }

                static float Multpile(float a, float b)
                {
                    float sum = a * b;
                    return sum;
                }

                static float Divide(float a, float b)
                {
                   float sum = 0;
                   if(b is 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Can not divide zero!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else

                        sum = a / b;
                        return sum;
                    
                }
            }

        }

        private static void system(string v)
        {
            throw new NotImplementedException();
        }
    }
}
