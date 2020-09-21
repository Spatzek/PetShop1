using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.DomainService
{
    public interface IPreviousOwnerRepository

    {
       

        public IEnumerable<Owner> ReadOwner();

        public Owner CreateOwner(Owner owner);
        public Owner PutOwner(Owner owner);
        public Owner DeleteOwner(int id);

        public Owner GetOwnerById(int id);

    }
}
