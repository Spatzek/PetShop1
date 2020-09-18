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
        public PetRepository()
    {

    }
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
        public Pet DeletePet(int id)
        {
            Pet pet = GetPetById(id);
            ((List<Pet>)_pets).Remove(pet);
            return pet;
        }
    }
}
