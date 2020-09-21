using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.DomainService
{
    public interface IPetTypeRepository
    {
       

        public IEnumerable<PetType> ReadPetType();

        public PetType CreatePetType(PetType petType);
        public PetType PutPetType(PetType petType);
        public PetType DeletePetType(int id);

        public PetType GetPetTypeById(int id);

    }
}
