using Stripe;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PetApp.Infastructure.Data
{
    public class PetAppContext : (DbContextOptions<PetAppContext> opt : base(opt)){}
    {
        public DbSet<PetShop>  { get; set; }
        public DbSet<Address> {get; set }
    }
}

