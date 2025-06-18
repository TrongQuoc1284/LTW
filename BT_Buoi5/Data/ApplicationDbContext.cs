using Microsoft.EntityFrameworkCore;
using BT_Buoi5.Models;

namespace BT_Buoi5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Book> Books { get; set; }
    }
} 