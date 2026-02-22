using System;

class Program
{
    static int add(int n1, int n2)
    {
        return n1 + n2;
    }

    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 7;

        int result = add(num1, num2);

        Console.WriteLine("Sum = " + result);
        Console.ReadKey();
    }
}