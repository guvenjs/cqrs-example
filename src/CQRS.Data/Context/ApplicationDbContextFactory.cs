using Microsoft.EntityFrameworkCore.Design;

namespace CQRS.Data.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            return new ApplicationDbContext();
        }
    }
}
