using Microsoft.EntityFrameworkCore;
using Web_API.Models;

namespace Web_API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    
    public DbSet<Octopus> Octopuses { get; set; }
}