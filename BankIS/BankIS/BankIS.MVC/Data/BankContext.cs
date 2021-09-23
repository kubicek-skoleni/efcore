using BankIS.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BankIS.MVC.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Address> Addresses { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=bankdb-mvc");

        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
