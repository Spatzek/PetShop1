using Microsoft.VisualBasic.FileIO;
using PetShop;
using PetShop.Core.Entity;
using PetShop.CORE.ApplicationService;
using PetShop.CORE.ApplicationService.Impl;
using PetShop.CORE.DomainService;
using PetShop.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace petShop2
{
    class Program
    {

        static void Main(string[] args)

        {
            string[] menuItems = {
                "list All pets",
                "Show Pets",
                "Search race",
                "Add Pet",
                "Delete Pet",
                "Edit Pet",
                "Sort Pets",
                "Search by price",
                "Exit",
            };

            var selection = ShowMenu(menuItems);
                while (selection != 1)
            {
                switch(selection)
                {
                    case 1:
                        ShowPets();
                        break;
                        /**
                    case 2:
                        SearchPets();
                        break;
                    case 3:
                        AddPet();
                        break;
                    case 4:
                        DeletePet();
                    case 5:
                        EditPet();
                        break;
                    case 6:
                        SortPrice();
                        break;
                    case 7:
                        SearchPrice();
                        break;
                    case 8:
                        Exit();
                        break;
                        */
                        
                }
                selection = ShowMenu(menuItems);

            }
            
            Console.WriteLine("");
            Console.ReadLine(); 
            Console.Clear();
        }


        public static int ShowMenu(string[] menuItems)
        {
            for (int i = 1; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 0)}: {menuItems[i]}");
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection >9)    
            {
                Console.WriteLine("Select a number between 1-8");
            }
            Console.WriteLine("Selected " + selection);
            return selection;
        }
        private static void ShowPets()
        {
            Console.WriteLine();
            foreach (var pet in FakeDB.pets)
            {
                Console.WriteLine(FakeDB.pets);
            }
            Console.WriteLine();
        }


    }
}