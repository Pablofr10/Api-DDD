using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            // Usado para criar Migrações
            var connectionString = "Server=DESKTOP-D9VV8QN;Database=dbAPI;Trusted_Connection=True";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
