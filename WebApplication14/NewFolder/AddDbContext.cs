using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace mysqlproject.Controllers.data
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options)
        {
        }

        // Replace 'YourEntity' with the name of your actual entity class.
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<e> email { get; set; }
        //public object Contact { get; internal set; }
    }

    // Example of an entity class (replace with your actual entity class definition)
    //public class YourEntity
    //{
    //    public int Id { get; set; }
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //}
}
