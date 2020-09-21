using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infastructure.Data
{
    public class PreviousOwnerRepository : IPreviousOwnerRepository { 

    private static IEnumerable<Owner> _owners = new List<Owner>();

    private static int _ownerId = 1;

        public IEnumerable<Owner> ReadOwner()
        {
            return _owners;
        }

        public Owner CreateOwner(Owner owner)
        {
            owner.OwnerId = _ownerId++;
         ((List<Owner>)_owners).Add(owner);
            return owner;
        }

        public Owner GetOwnerById(int id)
        {
            foreach (var owner in _owners)
            {
                if (owner.OwnerId == id)
                {
                    return owner;
                }

            }
            return null;
        }

        public Owner PutOwner(Owner owner)
        {
            Owner owner1 = GetOwnerById(owner.OwnerId);
            if (owner1 != null)
            {
                owner1.Name = owner.Name;
                owner1.Race = owner.Race;
                owner1.Birthdate = owner.Birthdate;
    
        }
            return owner1;
        }
        public Owner DeleteOwner(int id)
        {
            Owner owner = GetOwnerById(id);
            ((List<Owner>)_owners).Remove(owner);
            return owner;
        }


    }
}
