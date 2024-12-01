using Microsoft.EntityFrameworkCore;

namespace MafiaGameService.Infrastructure;

public class MafiaGameServiceDbContext : DbContext
{
    public MafiaGameServiceDbContext(DbContextOptions<MafiaGameServiceDbContext> options)
        : base(options) { }
}
