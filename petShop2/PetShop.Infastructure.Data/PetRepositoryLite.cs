using PetShop.Core.Entity;
using PetShop.CORE.DomainService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Infastructure.Data
{
    public class PetRepositoryLite: IPetRepository
    {
        private PetAppContext ctx;
        public PetRepositoryLite(PetAppContext)
        {
            _ctx = ctx;
        }
        public Pet Create(Pet pet)
        {
            var petEntry = _ctx.Add(pet);
            _ctx.SaveChanges();
            return petEntry.Entity;            
        }
        public Pet ReadById(int id)
        {
            return _ctx.Pet;

        }
        public FilteredList<Pet> ReadAll(FilterUIHintAttribute filter)
        {
            var filteredList = new FIlteredList<Pet>();
            
        }
    }
}
