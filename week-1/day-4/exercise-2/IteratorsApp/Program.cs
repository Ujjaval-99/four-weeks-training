using System;
using System.Collections;
using System.Collections.Generic;
public class FibonacciIterator : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        int previousNumber = 0;
        int currentNumber = 1;
        int count = 0;
        while (count < 9) // Generating first 10 numbers
        {
            yield return previousNumber;
            int nextNumber = previousNumber + currentNumber;
            previousNumber = currentNumber;
            currentNumber = nextNumber;
            count++;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
class Program
{
    static void Main(string[] args)
    {
        FibonacciIterator fibonacciIterator = new FibonacciIterator();
        foreach (int number in fibonacciIterator)
        {
            Console.WriteLine(number);
        }
    }
}