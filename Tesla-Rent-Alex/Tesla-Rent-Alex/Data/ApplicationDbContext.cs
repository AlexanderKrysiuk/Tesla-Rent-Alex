using Microsoft.EntityFrameworkCore;
using Tesla_Rent_Alex.Models;

namespace Tesla_Rent_Alex.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<TeslaOrder> TeslaOrders { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
    {
        
    }
}