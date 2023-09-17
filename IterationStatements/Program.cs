using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        /*        public static void PrintThousand()
                {
                    for (int i = 1000; i >= -1000; i--)
                    {
                        Console.WriteLine(i);
                    }
                }*/

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        /*        public static void PrintEveryThird()
                {
                    for (var a = 3; a <= 999; a+=3)
                    {
                        Console.WriteLine(a);
                    }
                }*/

        //Write a method to accept two integers as parameters and check whether they are equal or not
        /*        public static void PrintCompareIntegers()
                {
                    Console.WriteLine("Please choose a number:");
                    var a = Console.ReadLine();
                    Console.WriteLine("Please choose another number:");
                    var b = Console.ReadLine();

                    var variablesEqual = (a == b) ? "The variables are equal." : "The variables are NOT equal.";
                    Console.WriteLine(variablesEqual);
                    }
                }*/

        //Write a method to check whether a given number is even or odd
        /*        public static void CheckEvenOrOdd()
                {
                    Console.WriteLine("Please choose a number:");
                    int a = int.Parse(Console.ReadLine());

                    var evenOdd = (a % 2 == 0) ? "The number is even.") : "The number is odd.";
                    Console.WriteLine(evenOdd);
                    }

                }*/


        //Write a method to check whether a given number is positive or negative
        public static void CheckPositiveOrNegative()
        {
            Console.WriteLine("Please choose a number between -100 and 100:");
            int a = int.Parse(Console.ReadLine());

            var positiveNumber = (a >= 0) ? "The number is positive." : "The number is negative.";

            Console.WriteLine(positiveNumber);

        }

        //Write a method to read the age of a candidate and determine whether they can vote.


        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {


            /* PrintThousand();*/
            /*PrintEveryThird();*/
            /*PrintCompareIntegers();*/
            /*CheckEvenOrOdd();*/
            CheckPositiveOrNegative();



        }


    }
}
