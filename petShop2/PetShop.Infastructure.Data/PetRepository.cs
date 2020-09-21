using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infastructure.Data
{
    public class PetRepository : IPetRepository { 

    private static IEnumerable<Pet> _pets = new List<Pet>();

    private static int _petId = 1;

        public IEnumerable<Pet> ReadPets()
        {
            return _pets;
        }
        public Pet CreatePet(Pet pet)
        {
            pet.PetId = _petId++;
         ((List<Pet>)_pets).Add(pet);
            return pet;
        }

        public Pet GetPetById(int id)
        {
            foreach (var pet in _pets)
            {
                if (pet.PetId == id)
                {
                    return pet;
                }

            }
            return null;
        }
        public Pet PutPet(Pet pet)
        {

            Pet pet1 = GetPetById(pet.PetId);
            if (pet1 != null)
            {
                pet1.Name = pet.Name;
                pet1.Color = pet.Color;
                pet1.PreviousOwner = pet.PreviousOwner;
                pet1.Price = pet.Price;
                pet1.Race = pet.Race;
                pet1.SoldDate = pet.SoldDate;
                pet1.Birthdate = pet.Birthdate;

            }
            return pet1;
        }
        public Pet DeletePet(int id)
        {
            Pet pet = GetPetById(id);
            ((List<Pet>)_pets).Remove(pet);
            return pet;
        }
    }
}
