using System;

namespace Conditionals_Dalton_Lumpkin
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we ask the user for a number
            Console.WriteLine("Give Me A Whole numba");
            int num1 = Convert.ToInt32(Console.ReadLine());

            //See if evenOrOdd is well even or odd
            string evenOrOdd= (num1 % 2 == 0) ? "even" : "odd";

            // set answer to positive zero or negative
            string answer;
            if (num1 > 0) answer = "positive";
            else if (num1 == 0) answer = "Zero";
            else answer = "negative";

            //this just writes it out
            Console.WriteLine($" The number {num1} is a {answer}, {evenOrOdd} number");

            //asks for two more numbers
            Console.WriteLine("Now gimmi two more numbers bruh but only one at a time cuz im slow");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("and the second one?");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //finds bigest number
            Console.WriteLine(MathF.Max(num1, Math.Max(num2, num3)) + " is the largest number of the ones you gave me");

            Console.WriteLine("WHATS YOUR MATH GRADE DONT LIE I KNOW WHAT IT IS");
            Console.WriteLine("And make it capital letter");
            char grade = Convert.ToChar(Console.ReadLine());

            string gradeJudger;

            switch (grade)
            {
                case 'A':
                    gradeJudger = "actually good";
                    break;
                case 'B':
                    gradeJudger = "alr ig";
                    break;
                case 'C':
                    gradeJudger = "mid";
                    break;
                case 'D':
                    gradeJudger = "L grade";
                    break;
                case 'F':
                    gradeJudger = "Failing bozo";
                    break;
                default:
                    gradeJudger = "unacceptable letter";
                    break;
            }
            Console.WriteLine($"{Char.ToUpper(grade)}, is a {gradeJudger} grade. L");
        }
    }
}
