using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Resume.Models.DTO;
using Resume.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] ContactDto contact)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _contactService.CreateContact(contact);

            return Ok(contact);
        }
    }
}
