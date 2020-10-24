using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI
{
    public class ContextDB : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContextDB(DbContextOptions<ContextDB> options): base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}