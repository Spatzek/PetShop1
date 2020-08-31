using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Infastructure.Data
{
    public static class FakeDB
    {
        public static IEnumerable<Pet> pets = new List<Pet>();
        public static int id = 1;
        public static void initData()

        {
            Pet pet = new Pet()
            {
                PetId = id++,
                Name = "Sofus",
                Race = "Hund",
                Birthdate = DateTime.Parse("01.01.2010"),
                SoldDate = DateTime.Parse("10.10.2015"),
                Color = "Black",
                PreviousOwner = "Jack",
                Price = 100
            };
            ((List<Pet>)pets).Add(pet);
        }
    }
}
