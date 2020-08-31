using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.CORE.ApplicationService.Impl
{
    public class PetService : IPetService
    {
        private IPetRepository _petRepository;
        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;

        }
        public List<Pet> GetPets()
        {
            return _petRepository.ReadPets().ToList();
        }
    }
}
