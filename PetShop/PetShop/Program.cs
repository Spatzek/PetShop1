using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your name");

            string name = Console.ReadLine();

            var nameContainsJ = name.ToLower().Contains("j");

            Console.WriteLine("Hi " + name);
            if (nameContainsJ)
            { 
                Console.WriteLine("Your name Contains J");
            }
            else
            {
                Console.WriteLine("Your name does not contain J");
            }
         

            Console.WriteLine("Press any key to exit...");
        }
    }
}



