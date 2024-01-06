using Microsoft.EntityFrameworkCore;

namespace MvcLabManager.Models;

public class LabManagerContext : DbContext
{
    public DbSet<Computer> Computers { get; set; }
    
    public DbSet<Laboratory> Laboratories { get; set; }
    
    public LabManagerContext(DbContextOptions<LabManagerContext> options) : base(options)
    {
        
    }
}