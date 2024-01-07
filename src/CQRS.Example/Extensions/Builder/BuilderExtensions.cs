using CQRS.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Example.Extensions.Builder
{
    public static class BuilderExtensions
    {
        public static WebApplicationBuilder AddDbConnection(this WebApplicationBuilder builder)
        {
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
            builder.Services.AddDbContext<ApplicationDbContext>(conf => conf.UseSqlServer(connectionString));
            return builder;
        }
    }
}
