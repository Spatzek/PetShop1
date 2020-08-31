using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.DomainService
{
    public interface IPetRepository
    {
        public IEnumerable<Pet> ReadPets();

    }
}
