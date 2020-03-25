using Microsoft.EntityFrameworkCore;
using CustomersManager.Models;

namespace CustomersManager.Data
{
    public class MvcCustomerContext :DbContext
    {
        public MvcCustomerContext (DbContextOptions<MvcCustomerContext> options) :base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
    }
}
