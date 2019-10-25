using Microsoft.EntityFrameworkCore;
using TelephoneBook.Models;

namespace TelephoneBook.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            :base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}