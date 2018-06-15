using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bestwise.WJCourt.Authorization.Roles;
using Bestwise.WJCourt.Authorization.Users;
using Bestwise.WJCourt.MultiTenancy;
using Bestwise.WJCourt.Persons;
using Bestwise.WJCourt.Students;

namespace Bestwise.WJCourt.EntityFrameworkCore
{
    public class WJCourtDbContext : AbpZeroDbContext<Tenant, Role, User, WJCourtDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public WJCourtDbContext(DbContextOptions<WJCourtDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
