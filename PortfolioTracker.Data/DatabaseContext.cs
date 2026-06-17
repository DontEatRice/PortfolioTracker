using Microsoft.EntityFrameworkCore;

namespace PortfolioTracker.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
}