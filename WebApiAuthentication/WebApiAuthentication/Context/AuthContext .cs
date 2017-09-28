using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using WebApiAuthentication.Entities;

namespace WebApiAuthentication.Context
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}