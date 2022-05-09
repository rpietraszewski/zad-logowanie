using Years.Models;
using Microsoft.EntityFrameworkCore;

namespace Years.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
