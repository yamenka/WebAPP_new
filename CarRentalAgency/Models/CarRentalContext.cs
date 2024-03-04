using CarRentalAgency.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarRentalAgency
{
    public class CarRentalContext : IdentityDbContext<IdentityUser>
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars {get; set;}
        public DbSet<Client>  Clients {get; set;}
        public DbSet<Transaction> Transactions {get; set;}
    }
}
