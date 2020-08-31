using PetShop;
using PetShop.CORE.ApplicationService;
using PetShop.CORE.ApplicationService.Impl;
using PetShop.CORE.DomainService;
using PetShop.Infastructure.Data;
using System;

namespace petShop2
{
    class Program
    {

        static void Main(string[] args)
        {
            FakeDB.initData();
            IPetRepository petRepository = new PetRepository();
            IPetService petService = new PetService(petRepository);
            Printer printer = new Printer(petService);
            printer.StartUi();        
        }

    }
}