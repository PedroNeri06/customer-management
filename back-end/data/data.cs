using costumerManagement.Interface;
using costumerManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace costumerManagement.Data;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Costumer> constumer { get; set; }
    public DbSet<Check> check { get; set; }
}