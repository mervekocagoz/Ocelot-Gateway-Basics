using Contact.API.Models.ContactModels;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContact();

        public ContactDTO GetContactById(int Id);
    }
}