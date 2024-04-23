using AddtoDbWithxUnit.Models;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace AddtoDbWithxUnit.Brokers
{
    public class Broker : EFxceptionsContext, IBroker
    {
        public DbSet<User> Users { get; set; }


        public Broker() =>
            this.Database.EnsureCreated();

        public async ValueTask<User> AddUserAsync(User user)
        {
            await this.Users.AddAsync(user);
            await this.SaveChangesAsync();

            return user;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source = TestDb";

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
