using System;

namespace FizzyBuzzyThing
{
    class FizzyBuzzyThing
    {
        static void Main(string[] args)
        {         
            {
                int daNumba = 1;

                while (daNumba <= 100)
                {
                    string print;

                    if (daNumba % 3 == 0 && daNumba % 5 == 0)
                    {
                        print = "FizzBuzz";
                    }
                    else if (daNumba % 3 == 0)
                    {
                        print = "Fizz";
                    }
                    else if (daNumba % 5 == 0)
                    {
                        print = "Buzz";
                    }
                    else
                    {
                        print = daNumba.ToString();
                    }
                    daNumba++;
                    Console.WriteLine(print);
                }
                Console.ReadLine();
            }
        }
    }
}

