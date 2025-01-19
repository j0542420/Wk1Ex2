using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type your first name and press enter
            Console.WriteLine("What is your first name?");
            //Create a string variable and get user input
            string firstName = Console.ReadLine();

            //Type your last name
            Console.WriteLine("What is your last name?");
            //Create a string variable and get user input
            string lastName = Console.ReadLine();

            //Type your age
            Console.WriteLine("What is your age?");
            //Crate a string for your age
            int age = Convert.ToInt32(Console.ReadLine());

            //Type your favorite color
            Console.WriteLine("What is your favorite color?");
            //Create a string for your favorite color
            string color = Console.ReadLine();

            //Output the information that was typed in one sentence
            Console.WriteLine("Hello " + firstName + " " + lastName + "! You are " + age + " years old and your favorite color is " + color + ".");
        }
    }
}
