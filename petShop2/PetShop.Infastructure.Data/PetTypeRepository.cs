using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infastructure.Data
{
    public class PetTypeRepository : IPetTypeRepository
    {

        private static IEnumerable<PetType> _petsType = new List<PetType>();

        private static int _petTypeId = 1;

        public IEnumerable<PetType> ReadPetType()
        {
            return _petsType;
        }
        public PetType CreatePetType(PetType petType)
        {
            petType.PetTypeId = _petTypeId++;
            ((List<PetType>)_petsType).Add(petType);
            return petType;
        }

        public PetType GetPetTypeById(int id)
        {
            foreach (var petType in _petsType)
            {
                if (petType.PetTypeId == id)
                {
                    return petType;
                }

            }
            return null;
        }
        public PetType PutPetType(PetType petType)
        {

            PetType petType1 = GetPetTypeById(petType.PetTypeId);
            if (petType1 != null)
            {
                petType1.Name = petType.Name;
                petType1.Color = petType.Color;
                petType1.PreviousOwner = petType.PreviousOwner;
                petType1.Price = petType.Price;
                petType1.Race = petType.Race;
                petType1.SoldDate = petType.SoldDate;
                petType1.Birthdate = petType.Birthdate;

            }
            return petType1;
        }
        public PetType DeletePetType(int id)
        {
            PetType petType = GetPetTypeById(id);
            ((List<PetType>)_petsType).Remove(petType);
            return petType;
        }




        }
    }
