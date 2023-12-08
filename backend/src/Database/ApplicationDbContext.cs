using Llogin.Models;
using Microsoft.EntityFrameworkCore;

namespace Llogin.Database;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
}