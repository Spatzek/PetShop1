using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetShop.Core.Entity;
using PetShop.CORE.ApplicationService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService service)
        {
            _petService = service;
        }



        // GET: api/<PetsController>
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()

        {
            return Ok(_petService.GetPets());
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]

        public Pet Get(int id)
        {
            return _petService.GetPetById(id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public ActionResult<Pet> Post([FromBody] Pet pet)
        {
            if (pet.PetId <= 1)
            {
                return StatusCode(500, "PetId cannot be less than One");
            }
            return _petService.CreatePet(pet);

     
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public ActionResult<Pet> Delete(int id)
        {
            var pet = _petService.DeletePet(id);
            if (pet == null)
            {
                return StatusCode(404, "Pet not found");
            }
            else
            {
                return pet;
            }
        }
    }
}
