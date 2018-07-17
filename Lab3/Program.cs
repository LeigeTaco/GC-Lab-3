using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    class Program
    {

        static int GetInputMethod(string name)
        {

            int entry = 0;
            bool whileBreak = false;
            bool innerBreak = false;

            while (!whileBreak)
            {

                Console.WriteLine($"{name}, please enter a number between 1 and 100.");

                innerBreak = false;

                do
                {

                    try
                    {

                        entry = int.Parse(Console.ReadLine());

                        if (entry >= 1 && entry <= 100)
                        {

                            Console.WriteLine("Input validated, proceeding...");
                            innerBreak = true;
                            whileBreak = true;

                        }

                        else if (entry < 2)
                        {

                            Console.WriteLine("Error: Invalid entry (Number less than lower bound)");
                            innerBreak = true;

                        }

                        else if (entry > 99)
                        {

                            Console.WriteLine("Error: Invalid entry (Number greater than upper bound)");
                            innerBreak = true;

                        }

                        else
                        {

                            Console.WriteLine("Unknown Error Occured");
                            innerBreak = true;

                        }

                    }

                    catch (FormatException)
                    {

                        Console.WriteLine("Error: Invalid entry (Not a whole number)");

                    }

                    catch (OverflowException)
                    {

                        Console.WriteLine($"Error: Invalid entry (Number way too large, chill {name})");

                    }

                } while (!innerBreak);

            }

            return entry;

        }

        static void CompareMethod(int x)
        {

            if ((x % 2) == 1) //Odd test
            {

                //Console.WriteLine("Odd."); Redundant

                if (x > 60) //Odd 60+
                {

                    Console.WriteLine($"Odd: {x}.");

                }

                else //Odd else
                {

                    Console.WriteLine($"Odd: {x}.");

                }

            }

            else //Even
            {

                if(x > 60)
                {

                    Console.WriteLine($"Even: {x}.");

                }

                else if (x > 25)
                {

                    Console.WriteLine("Even.");

                }

                else if (x > 1)
                {

                    Console.WriteLine("Even and less than 25");

                }

                else
                {

                    //Guess nothing goes here /shrug

                }

            }



            return;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, welcome to Number Logic!");
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            char repeat = 'y';

            do
            {

                int number = GetInputMethod(name);

                CompareMethod(number);

                Console.WriteLine($"{name}, do you want to do another test? (Y/N)");
                repeat = Char.Parse(Console.ReadLine());

            } while (Char.ToLower(repeat) == 'y');

            Console.WriteLine("See ya next time " + name);

        }

    }

}
