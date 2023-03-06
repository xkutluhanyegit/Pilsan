using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = /Users/kutluhanyegit/Desktop/Pilsan/DataAccess/SQLite/App.db");
        }
        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<AppOperationClaim> appOperationClaims { get; set; }
        public DbSet<AppUserOperationClaim> appUserOperationClaims { get; set; }
    }
}