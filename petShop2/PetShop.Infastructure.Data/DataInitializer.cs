using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PetShop.Infastructure.Data
{
    
    public class DataInitializer
    {
        private IPetTypeRepository _petTypeRepository;
        private IPetRepository _petRepository;
        private IPreviousOwnerRepository _previousOwnerRepository;
        public DataInitializer(IPetRepository petRepository, IPreviousOwnerRepository previousOwnerRepository, IPetTypeRepository petTypeRepository)
        {
            _petRepository = petRepository;
            _previousOwnerRepository = previousOwnerRepository;
            _petTypeRepository = petTypeRepository;
        }
        public void INitData()
        {
            var pet1 = _petRepository.CreatePet( new Pet()
            {
                Name = "Mickey",
                Color = "red",
                Race = "Cat",
                PreviousOwner = "Bob Dylan",
                Price = 100,
            });

            
                var pet2 = _petRepository.CreatePet(new Pet()
                {
                Name = "Peter",
                Color = "Black",
                Race = "Dog",
                PreviousOwner = "Man Dylan",
                Price = 150,
            });
            var owner1 = _previousOwnerRepository.CreateOwner(new Owner()
            {
                Name = "Ceasar Melan",
                Race = "Human",

            });
            var petType1 = _petTypeRepository.CreatePetType(new PetType()
            {
                Name = "Doggo",
                Race = "Dog"
            });
                
        }

    }
}
