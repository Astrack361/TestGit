using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Merakis.Models.Data
{
    public class DBcontext : IdentityDbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Mechanical> Mechanical { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<WorkOrder> WorkOrder { get; set; }
        public DbSet<WorkShop> WorkShop { get; set; }

    }
}
        


