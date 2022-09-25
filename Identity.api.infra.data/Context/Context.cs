using Identity.api.domain;
using Identity.api.domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.api.infra.data.Context
{
    class Context : IdentityDbContext<User, Role, int,
                                     IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
                                             IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserMap());
            modelBuilder.ApplyConfiguration<Role>(new RoleMap());
            modelBuilder.ApplyConfiguration<UserRole>(new UserRoleMap());
        }
    }
}
