
using Microsoft.EntityFrameworkCore;

namespace ProductMasterService
{
    public class ProductsMasterDbContext: DbContext
    {
        public ProductsMasterDbContext(DbContextOptions<ProductsMasterDbContext> options)
        : base(options){ }
        
        public DbSet<SubService> SubServices { get; set; }
    }
}