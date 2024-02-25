using Duende.IdentityServer.Models;
using Mango.Services.Identity.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Mango.Services.Identity.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }

    /// <summary>
    /// ApplicationDbContextFactory является фабрикой для создания экземпляров ApplicationDbContext во время проектирования (Design Time). 
    /// Реализует интерфейс IDesignTimeDbContextFactory<ApplicationDbContext>, что позволяет использовать его с инструментами проектирования, 
    /// например, с Entity Framework Core Tools.
    ///В методе CreateDbContext, создается экземпляр DbContextOptionsBuilder<ApplicationDbContext> и настраивается для использования SQL Server 
    ///с указанными параметрами подключения.Затем создается новый объект ApplicationDbContext с использованием настроенных параметров.
    ///Этот класс и фабрика обычно используются в контексте разработки базы данных, например, при применении миграций или создании начальных данных.
    /// </summary>
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Database=MangoIdentityServer;Trusted_Connection=True;TrustServerCertificate=true");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
