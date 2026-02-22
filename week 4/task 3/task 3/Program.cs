using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "data.txt";

        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine("Hello");
        file.Flush();
        file.Close();

        Console.WriteLine("Data written successfully.");
        Console.ReadKey();
    }
}