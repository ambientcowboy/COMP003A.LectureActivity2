using System;

namespace COMP003A.LectureActivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String? input1 = Console.ReadLine()!;
            Console.Write("Enter second number: ");
            String? input2 = Console.ReadLine()!;
            double a = double.Parse(input1);
            double b = double.Parse(input2);
            double sum = a + b;
            double average = (a + b) / 2.0;
            Console.WriteLine("\tUsing Concatenation");
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("\t Using Interpolation");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
            Console.WriteLine("\tOutput Comparisons");
            bool aGreaterThanB = a > b;
            bool aEqualsB = a == b;
            Console.WriteLine($"a>b = {aGreaterThanB}");
            Console.WriteLine ($"a=b = {aEqualsB}");
        }
    }
}