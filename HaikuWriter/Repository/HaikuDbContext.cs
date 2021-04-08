using Microsoft.EntityFrameworkCore;
using System;

using Models;

namespace Repository
{
    public class HaikuDbContext : DbContext
    {
        public HaikuDbContext(DbContextOptions<HaikuDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<HaikuLine> HaikuLines { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<UserFav> UserFavs { get; set; }
        public DbSet<Haiku> Haikus { get; set; }
        //public DbSet<UserWrote> UserWrotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"connection string");
            // @“Server=127.0.0.1;Database=Master;User Id=SA;Password=1Secure*Password1;”
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ManyToManyRelationshipConfiguration(modelBuilder);
        }

        // Method to setup many to many relationship for ef
        private void ManyToManyRelationshipConfiguration(ModelBuilder modelBuilder)
        {
            //Model config for many to many relation for userfav
            modelBuilder.Entity<UserFav>()
                .HasKey(uf => new { uf.UserId, uf.HaikuId });

            modelBuilder.Entity<UserFav>()
                .HasOne(uf => uf.User)
                .WithMany(u => u.UserFavs)
                .HasForeignKey(uf => uf.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserFav>()
                .HasOne(uf => uf.Haiku)
                .WithMany(h => h.UserFavs)
                .HasForeignKey(uf => uf.HaikuId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.User)
                .WithMany(u => u.Messages)
                .OnDelete(DeleteBehavior.Restrict);

        }


    }
}