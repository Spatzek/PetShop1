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
        static int petId = 1;
        static List<Pet> pets = new List<Pet>();

        static void Main(string[] args)

        {

            var pet1 = new Pet()
            {
                PetId = petId++,
                Name = "Mickey",
                Color = "red",
                Race = "Cat",
                PreviousOwner = "Bob Dylan",
                Price = 100,
            };
            pets.Add(pet1);

            pets.Add(new Pet()
            {
                PetId = petId++,
                Name = "Peter",
                Color = "Black",
                Race = "Dog",
                PreviousOwner = "Man Dylan",
                Price = 150,
            });

            

            string[] menuItems = {
                "list All pets",
                "Show Pets",
                "Add Pet",
                "Search Race",
                "Delete Pet",
                "Edit Pet",
                "Sort Pets",
                "Search by price",
                "Exit",
            };

            var selection = ShowMenu(menuItems);
                while (selection != 9)
            {
                switch(selection)
                {
                    case 1:
                        ShowPets();
                        break;
                        
                    case 2:
                        AddPets();
                        break;
                        /*
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
            Console.WriteLine("closeing program");
           
            Console.ReadLine(); 
            
        }

        private static void AddPets()
        {
            Console.WriteLine("Pet Id: ");
            int PetId = petId++;

            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Race: ");
            var race = Console.ReadLine();

            Console.WriteLine("Color: ");
            var color = Console.ReadLine();

            Console.WriteLine("PreviousOwner: ");
            var previousOwner = Console.ReadLine();

            Console.WriteLine("Price: ");
            var price = Console.ReadLine();

            pets.Add(new Pet()
            {
                PetId = PetId++,
                Name = name,
                Race = race,
                Color = color,
                PreviousOwner = previousOwner,
                //Price = double price,

            });
        }

        private static string GetPetId()
        {
            return Console.ReadLine();
        }

        private static void ShowPets()
        {
            
            foreach (var Pet in pets)
            {
                Console.WriteLine($"PetId: {Pet.PetId}");
                Console.WriteLine($"Name: {Pet.Name }");
                Console.WriteLine($"Race: {Pet.Race}");
                Console.WriteLine($"Color: {Pet.Color }");
                Console.WriteLine($"PreviousOwner: {Pet.PreviousOwner}");
                Console.WriteLine($"Price: {Pet.Price }");
                Console.WriteLine("\n");

            }
            Console.WriteLine("\n");
        }
        public static int ShowMenu(string[] menuItems)
        {
          
            Console.WriteLine("Select an option:\n");
            
            for (int i = 1; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{(i + 0)} :{menuItems[i]}");
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1
                || selection >9)    
            {
                Console.WriteLine("Select a number between 1-8");
            }
           
            return selection;
        }



    }
}