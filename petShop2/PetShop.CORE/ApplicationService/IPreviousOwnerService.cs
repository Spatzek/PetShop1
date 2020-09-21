using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.CORE.ApplicationService
{
    public interface IPreviousOwnerService
    {
        public List<Owner> GetOwners();
        
        public Owner DeleteOwner(int id);
        public Owner PutOwner(Owner owner);
        public Owner GetOwnerById(int id);

        public Owner CreateOwner(Owner owner);
 
    }
}
