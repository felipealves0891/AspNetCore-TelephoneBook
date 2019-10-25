using System;

namespace TelephoneBook.Models
{
    public class Contact
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public string CellPhone { get; set; }
    }
}