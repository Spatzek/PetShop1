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
    public class PetTypeController : ControllerBase
    {
        private readonly IPetTypeService _petTypeService;

        public PetTypeController(IPetTypeService service)
        {
            _petTypeService = service;
        }



        // GET: api/<PetsController>
        [HttpGet]
        public ActionResult<IEnumerable<PetType>> Get()

        {
            return Ok(_petTypeService.GetPetType());
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]

        public PetType GetPetsType(int id)
        {
            return _petTypeService.GetPetTypeById(id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public ActionResult<PetType> Post([FromBody] PetType petType)
        {
            if (petType.PetTypeId <= 1)
            {
                return StatusCode(500, "PetId cannot be less than One");
            }
            if (petType.Color == null)
            {
                return StatusCode(500, "You must select a color");
            }

            if (petType.Name == null)
            {
                return StatusCode(500, "You must write a name");
            }

            else

                return _petTypeService.CreatePetType(petType);

     
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public ActionResult<PetType> Put(int id, [FromBody] PetType petType)
        {
            var petType1 = _petTypeService.PutPetType(petType);
            if (petType1 == null)
            {
                return StatusCode(404, "PetType not found");
            }
            else
            {
                return StatusCode(202,petType1);
            }
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public ActionResult<PetType> Delete(int id)
        {
            var petType = _petTypeService.DeletePetType(id);
            if (petType == null)
            {
                return StatusCode(404, "PetType not found");
            }
            
            else
            {
                return petType;
            }
        }
    }
}
