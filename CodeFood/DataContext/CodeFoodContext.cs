using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Models
{
    public class CodeFoodContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public CodeFoodContext(DbContextOptions<CodeFoodContext> options): base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            builder.Entity<User>()
                .HasIndex(u => u.PhoneNumber)
                .IsUnique();

            builder.Entity<User>()
                .HasIndex(u => u.LinkedInUrl)
                .IsUnique();
        }
    }
}
