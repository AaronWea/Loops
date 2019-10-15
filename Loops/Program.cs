using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int iNum1;
            int iNum2;
            int iAnswer;
            char cAgain;

            do
            {
                Console.Clear();
                Console.WriteLine("Please input first number: ");
                iNum1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input the second number: ");
                iNum2 = int.Parse(Console.ReadLine());

                iAnswer = iNum1 + iNum2;
                Console.WriteLine("Added together " + iNum1 + " and " + iNum2 + " which is " + iAnswer);

                Console.WriteLine();
                System.Threading.Thread.Sleep(3000);
                Console.Write("Would you like to add more numbers? Enter either (Y/N): ");
                cAgain = char.Parse(Console.ReadLine());
                cAgain = char.ToUpper(cAgain);
            } while (cAgain == 'Y');


        }
    }
}
