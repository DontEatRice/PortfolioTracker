using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PortfolioTracker.Data.Extensions;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection collection)
    {
        public IServiceCollection AddDatabaseContext(string path)
        {
            collection.AddDbContext<DatabaseContext>(options => options.UseSqlite($"Data Source={path}"));
            return collection;
        }
    }
}