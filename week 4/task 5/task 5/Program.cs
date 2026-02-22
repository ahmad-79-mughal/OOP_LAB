using System;
using System.IO;

class Program
{
    static void pizza_points(int minOrders, int minPrice)
    {
        string path = "Customers.txt";

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                int orders = int.Parse(parts[1]);

                string pricesPart = line.Substring(line.IndexOf('(') + 1);
                pricesPart = pricesPart.Replace(")", "");

                string[] prices = pricesPart.Split(',');

                int count = 0;

                foreach (string price in prices)
                {
                    if (int.Parse(price) >= minPrice)
                        count++;
                }

                if (orders >= minOrders && count >= minOrders)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        pizza_points(5, 20);
        Console.ReadKey();
    }
}