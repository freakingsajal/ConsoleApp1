using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace API.Authentication
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LoginModel>().ToTable("LoginModel");
            builder.Entity<RegisterModel>().ToTable("RegisterModel");
            builder.Entity<Response>().ToTable("Response");
            builder.Entity<UserRoles>().ToTable("UserRoles");


        }
    }
}
