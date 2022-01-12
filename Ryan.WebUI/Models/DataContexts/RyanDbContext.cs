using Microsoft.EntityFrameworkCore;
using Ryan.WebUI.Models.Entities;

namespace Ryan.WebUI.Models.DataContexts
{
    public class RyanDbContext : DbContext
    {
        public RyanDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
