using Microsoft.EntityFrameworkCore;
using UnitOfWork.Models;

namespace UnitOfWork.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
