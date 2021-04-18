using Contact.API.Infrastructure;
using Contact.API.Models.ContactModels;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService ContactService)
        {
            contactService = ContactService;
        }

        [HttpGet]
        public ContactDTO Get()
        {
            return contactService.GetContact();
        }

        [HttpGet("{id}")]
        public ContactDTO GetContactById(int Id)
        {
            return contactService.GetContactById(Id);
        }
    }
}