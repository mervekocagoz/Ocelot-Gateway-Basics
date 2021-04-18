using System;

namespace Contact.API.Models.ContactModels
{
    public class ContactDTO
    {
        public int Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";
    }
}