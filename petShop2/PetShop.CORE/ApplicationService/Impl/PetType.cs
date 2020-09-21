using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.CORE.ApplicationService.Impl
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepository _petTypeRepository;
        public PetTypeService(IPetTypeRepository petTypeRepository)
        {
            _petTypeRepository = petTypeRepository;
        }

        public PetType CreatePetType(PetType petType)
        {
            return _petTypeRepository.CreatePetType(petType);
        }
        public PetType PutPetType(PetType petType)
        {
            return _petTypeRepository.PutPetType(petType);
        }
        public PetType DeletePetType(int id)
        {
            return _petTypeRepository.DeletePetType(id);
        }

        public PetType GetPetTypeById(int id)
        {
            return _petTypeRepository.GetPetTypeById(id);
        }

        public List<PetType> GetPetType()
        {
            return _petTypeRepository.ReadPetType().ToList();
        }
    }
}
