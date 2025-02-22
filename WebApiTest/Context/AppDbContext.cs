using Microsoft.EntityFrameworkCore;
using WebApiTest.Models;

namespace WebApiTest.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Facturas> FACTURAS { get; set; }
        public DbSet<Detalle_Facturas> DETALLE_FACTURAS { get; set; }
    }
}
