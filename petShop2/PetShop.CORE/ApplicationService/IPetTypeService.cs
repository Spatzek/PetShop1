using PetShop.Core.Entity;
using PetShop.CORE.ApplicationService.Impl;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.ApplicationService
{
    public interface IPetTypeService
    {
        public List<PetType> GetPetType();
        public PetType DeletePetType(int id);

        public PetType PutPetType(PetType petType);
        public PetType GetPetTypeById(int id);

        public PetType CreatePetType(PetType petType);
    }
}
