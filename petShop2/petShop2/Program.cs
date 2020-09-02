using PetShop;
using PetShop.CORE.ApplicationService;
using PetShop.CORE.ApplicationService.Impl;
using PetShop.CORE.DomainService;
using PetShop.Infastructure.Data;
using System;

namespace petShop2
{
    class Program
    {

        static void Main(string[] args)

        {
            string[] menuItems = {
                "list All customers",
                "Add Customer",
                "Delete Customer",
                "Edit Customer",
                "Exit",
            };
            ShowMenu(menuItems);
            Console.ReadLine();
        }

        private static int ShowMenu(string[] menuItems)
        {
            Console.Clear();
            Console.WriteLine("Select an option");
            Console.WriteLine("");



            for (int i = 1; i < menuItems.Length; i++)
            {
                Console.WriteLine(i + ":" + menuItems[i]);
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection >5)
            {
                Console.WriteLine("Select a number between 1-5");
            }
            Console.WriteLine("Selection " + selection);
            return selection;
        }
    }
}