using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDetailsEntered:");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Surname " + surname);
            Console.WriteLine("Age "+ age); 
        }
    }
}
