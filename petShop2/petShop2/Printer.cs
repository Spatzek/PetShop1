using PetShop.Core.Entity;
using PetShop.CORE.ApplicationService;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PetShop
{
    public class Printer
        
    {
        private IPetService _petService;
        public Printer(IPetService petService)
        {
            _petService = petService;

        }
        public void StartUi()
        {
            List<Pet> pets = _petService.GetPets();
            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.PetId}\n{pet.Name}\n{pet.Race}\n{pet.Birthdate}\n{pet.SoldDate}\n{pet.Price}");
            }

        }
    }
}
