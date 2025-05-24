using Microsoft.EntityFrameworkCore;
using BulkyWeb.Models;
using System.ComponentModel;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<CategoryAttribute> MyProperty { get; set; }

    }
}
