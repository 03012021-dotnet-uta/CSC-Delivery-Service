using Microsoft.EntityFrameworkCore;
using System;

using Models;

namespace Repository
{
    public class HaikuDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<HaikuLine> HaikuLines { get; set; }
        // public DbSet<Admin> Admin { get; set; }
        // public DbSet<Thred> thread { get; set; }
        // public DbSet<Message> message { get; set; }

        		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			 optionsBuilder.UseSqlServer(@"connection string");
            // @“Server=127.0.0.1;Database=Master;User Id=SA;Password=1Secure*Password1;”
		}
    }
}