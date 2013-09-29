using System.Data.Entity;
using Tamagotchi.Model;

namespace Tamagotchi.Data
{
    public class TamagotchiContext : DbContext
    {
        public TamagotchiContext() : base("TamagotchiDb")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .Property(usr => usr.SessionKey)
                        .IsFixedLength()
                        .HasMaxLength(50);
            base.OnModelCreating(modelBuilder);
        }
    }
}