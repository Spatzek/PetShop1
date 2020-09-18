using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.ApplicationService
{
    public interface IPetService
    {
        public List<Pet> GetPets();
        public Pet DeletePet(int id);

        public Pet GetPetById(int id);

        public Pet CreatePet(Pet pet);
    }
}
