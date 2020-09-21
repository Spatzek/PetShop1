using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.DomainService
{
    public interface IPetRepository
    {
       

        public IEnumerable<Pet> ReadPets();

        public Pet CreatePet(Pet pet);
        public Pet PutPet(Pet pet);
        public Pet DeletePet(int id);

        public Pet GetPetById(int id);

    }
}
