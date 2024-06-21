using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repository;

namespace CompanyEmployees.ContextFactory
{
    public class RepositoryContextFactory:IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args) {
            var serverVersion = new MySqlServerVersion(new Version(8, 0));
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                        .UseMySql(configuration.GetConnectionString("sqlConnection"),
                        serverVersion,
                        b=>b.MigrationsAssembly("CompanyEmployees"));

            return new RepositoryContext(builder.Options);
        }

        
    }
}