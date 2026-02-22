using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "data.txt";

        if (File.Exists(path))
        {
            StreamReader file = new StreamReader(path);
            string line;

            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            file.Close();
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }

        Console.ReadKey();
    }
}