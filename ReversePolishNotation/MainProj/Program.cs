using System;
using SolutionLib;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string exp = "10000 123 + *";
            string exp1 = "10000 123 + ";
            string exp2 = "10000 123 +";
            string exp3 = "1 2 3.5";
            string exp4 = "5 1 2 + 4 * + 3 -";
            string exp5 = "5 1 2 + 4 * + 3- ";
            string exp6 = "5 1 2 + 4 * -3 -";
            string exp7 = "5 1 2 + + 2 - 3 / 2";


            Console.WriteLine("Results...");
            Console.WriteLine("------------\n");

            Console.Write($"({exp})  =>>  ");
            DisplayResult(exp);

            Console.Write($"({exp1})  =>>  ");
            DisplayResult(exp1);

            Console.Write($"({exp2})  =>>  ");
            DisplayResult(exp2);

            Console.Write($"({exp3})  =>>  ");
            DisplayResult(exp3);

            Console.Write($"({exp4})  =>>  ");
            DisplayResult(exp4);

            Console.Write($"({exp5})  =>> ");
            DisplayResult(exp5);

            Console.Write($"({exp6})  =>>  ");
            DisplayResult(exp6);

            Console.Write($"({exp7})  =>>  ");
            DisplayResult(exp7);


        }

        private static void DisplayResult(string exp)
        {
            try
            {
                Console.WriteLine(Challenge.Evaluate(exp));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
