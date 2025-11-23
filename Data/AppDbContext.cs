using Cognifind.Models;
using Microsoft.EntityFrameworkCore;   // ✅ IMPORTANT
using System.Collections.Generic;

namespace Cognifind.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }  // ✅ Your table
    }
}

