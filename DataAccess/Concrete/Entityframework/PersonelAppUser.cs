using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Entityframework
{
    public class PersonelAppUser:IdentityDbContext<AppUser,AppRole,string>
    {
        public PersonelAppUser()
        {
            
        }
        public PersonelAppUser(DbContextOptions<PersonelAppUser> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.79;Database=PersonelUsers;User Id=kutluhan;Password=helloWorld2023.;");
        }
    }
}