namespace Wk1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string firstName = "";
            string lastName = "";
            int age = "0";
            string color = "";

            //print out the prompt to ask for first name input
            Console.WriteLine("What is your first name?");
            //collect the user input for first name
            firstName = Console.ReadLine();

            //print out the prompt to ask for last name input
            Console.WriteLine("What is your last name?");
            //collect the user input for last name
            lastName = Console.ReadLine();

            //print out the prompt to ask for your age
            Console.WriteLine("What is your age?");
            //collect the user input for their age
            age = Convert.ToInt32(Console.ReadLine());

            //print out the prompt to ask for your favorite color input
            Console.WriteLine("What is your favorite color?");
            //collect the user input for your favorite color
            color = Console.ReadLine();

            //Output the information that was typed in one sentence
            Console.WriteLine("Hello " + firstName + " " + lastName + "! You are " + age + " years old and your favorite color is " + color + ".");

			Console.WriteLine($"Hello {firstName} {lastName}! You are {age} years old and your favorite color is {color}.);
		}
    }
}
