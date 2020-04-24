using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name?");
            string lastName = Console.ReadLine();

            if (firstName.ToLower() == "derek" && lastName.ToLower() == "sparks")
            {
                Console.WriteLine("Hello Professor Derek!");
            }
            else if (firstName.ToLower() == "sam" && lastName.ToLower() == "vongphonthong")
            {
                Console.WriteLine("Hello Sam");
            }
            else
            {
                Console.WriteLine("Hello student");
            }

            Console.WriteLine();
            Console.WriteLine("Application done!");

            Console.ReadLine();
        }
    }
}
