
using Microsoft.EntityFrameworkCore;
using shopping_app.Models;

namespace shopping_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add your tables here (DbSet)
        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<CustomerCoupon> Customer_Coupons { get; set; }
        
    }
}
