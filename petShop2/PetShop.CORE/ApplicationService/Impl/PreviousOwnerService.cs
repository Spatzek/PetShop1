using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.CORE.ApplicationService.Impl
{
    public class PreviousOwnerService : IPreviousOwnerService
    {
        private IPreviousOwnerRepository _previousOwnerRepository;

        public PreviousOwnerService(IPreviousOwnerRepository previvousOwnerRepository)
        {
            _previousOwnerRepository = previvousOwnerRepository;
        }

        public Owner CreateOwner(Owner owner)
        {
            return _previousOwnerRepository.CreateOwner(owner);
        }
        public Owner PutOwner(Owner owner)
        {
            return _previousOwnerRepository.PutOwner(owner);
        }
        public Owner DeleteOwner(int id)
        {
            return _previousOwnerRepository.DeleteOwner(id);
        }

        public Owner GetOwnerById(int id)
        {
            return _previousOwnerRepository.GetOwnerById(id);
        }


        public List<Owner> GetOwners()
        {
            return _previousOwnerRepository.ReadOwner().ToList();
        }
    }
}