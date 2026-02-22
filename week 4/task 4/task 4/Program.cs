using System;
using System.IO;

class Program
{
    static string path = "users.txt";

    static void SignUp()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        StreamWriter file = new StreamWriter(path, true);
        file.WriteLine(username + "," + password);
        file.Close();

        Console.WriteLine("Signup Successful!");
    }

    static void SignIn()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            bool found = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts[0] == username && parts[1] == password)
                {
                    found = true;
                    break;
                }
            }

            if (found)
                Console.WriteLine("Login Successful!");
            else
                Console.WriteLine("Invalid Credentials!");
        }
        else
        {
            Console.WriteLine("No users found.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("1. Sign Up");
        Console.WriteLine("2. Sign In");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
            SignUp();
        else if (choice == 2)
            SignIn();
        else
            Console.WriteLine("Invalid Choice");

        Console.ReadKey();
    }
}