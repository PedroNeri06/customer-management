using costumerManagement.Interface;
using Microsoft.EntityFrameworkCore;

namespace costumerManagement.Data;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<IconstumerBr> constumerBr { get; set; }
}