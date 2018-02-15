using Identity.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.API.Context
{
    public class SecurityContext : IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(GetConnectionString(), sqlOptions =>
                           sqlOptions.MigrationsAssembly("Identity.API"));
        }

        private static string GetConnectionString()
        {
            const string databaseName = "api.Identity";
            const string databaseUser = "sa";
            const string databasePass = "a";

            return $"Server=MATYS-HP\\SQL14;" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }

    }
}
