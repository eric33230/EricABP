using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EricABP.Authorization.Roles;
using EricABP.Authorization.Users;
using EricABP.MultiTenancy;
using EricABP.PhoneBooks.Persons;
using EricABP.PhoneBooks.PhoneNumbers;
using Abp.Localization;

namespace EricABP.EntityFrameworkCore
{
    public class EricABPDbContext : AbpZeroDbContext<Tenant, Role, User, EricABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EricABPDbContext(DbContextOptions<EricABPDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }


        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        //Initial_Migrations


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //     modelBuilder.Entity<ApplicationLanguageText>().Property(p => p.Value).HasMaxLength(500);
            modelBuilder.Entity<Person>().ToTable("Person", "dbo");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "dbo");

            base.OnModelCreating(modelBuilder);
        }




    }
}
