using Contact.API.Infrastructure;
using Contact.API.Models.ContactModels;

namespace Contact.API.Service
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContact()
        {
            return new ContactDTO()
            {
                Id = 1, //Guid.NewGuid(),
                FirstName = "Merve",
                LastName = "KOCAGÖZ"
            };
        }

        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Sertaç",
                LastName = "Kocagöz"
            };
        }
    }
}