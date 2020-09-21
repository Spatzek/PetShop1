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
    public class PreviousOwnerController : ControllerBase
    {
        private readonly IPreviousOwnerService _previousOwnerService;


        public PreviousOwnerController(IPreviousOwnerService Service)

        {
            _previousOwnerService = Service;
        }


        // GET: api/<PreviousOwnerController>
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return Ok(_previousOwnerService.GetOwners());
        }

        // GET api/<PreviousOwnerController>/5
        [HttpGet("{id}")]
        public Owner Get(int id)
        {
            return _previousOwnerService.GetOwnerById(id);
        }

        // POST api/<PreviousOwnerController>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            if (owner.OwnerId <= 1)
            {
                return StatusCode(500, "OwnerId cannot be less than one");
            }
            else
                return _previousOwnerService.CreateOwner(owner);
        }


        // PUT api/<PreviousOwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<Pet> Put(int id, [FromBody] Owner owner)
        {
            var owner1 = _previousOwnerService.PutOwner(owner);
            if (owner1 == null)
            {
                return StatusCode(404, "Owner could not be found");
            }
            else
            {
                return StatusCode(202, owner1);
            }

        }

        // DELETE api/<PreviousOwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<Owner> Delete(int id)
        {
            var owner = _previousOwnerService.DeleteOwner(id);
            if (owner == null)
            {
                return StatusCode(404, "Owner not found");
            }

            else
            {
                return owner;
            }
        }
    }
}