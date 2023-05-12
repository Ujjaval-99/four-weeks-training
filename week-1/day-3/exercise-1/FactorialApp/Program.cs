// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    public static void Main()
    {
        Console.Write("Enter NO: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = CalculateFactorial(number);
        Console.WriteLine($" The Factorial Of {number} is {factorial}");
    }
    public static int CalculateFactorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
            result *= i;
        }
        return result;
    }
}
