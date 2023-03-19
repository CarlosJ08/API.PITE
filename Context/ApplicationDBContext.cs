using API.PITE.Models;
using Microsoft.EntityFrameworkCore;

namespace API.PITE.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
        {
        }
    }
}
