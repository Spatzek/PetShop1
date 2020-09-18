using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infastructure.Data
{
    
    public class DataInitializer
    {
        private IPetRepository _petRepository;
        public DataInitializer(IPetRepository petRepository)
        {
            _petRepository = petRepository;
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
        }
    }
}
