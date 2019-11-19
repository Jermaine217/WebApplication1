using Microsoft.EntityFrameworkCore;
using ContosoPets.Api.Models;
using WebApplication1.Models;

namespace ContosoPets.Api.Data
{
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options)
            : base(options)
        {
        }

        public DbSet<TShirtOrder> TShirtOrders { get; set; }
    }
}