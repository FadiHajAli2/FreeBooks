using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domin.Entity;
using Infrastructure.ViewModel;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data
{
    public class FreeBookDbContext:IdentityDbContext<ApplicationUser>
    {
        public FreeBookDbContext(DbContextOptions<FreeBookDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<LogCategory>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<SubCategory>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<LogSubCategory>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<Book>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            builder.Entity<LogBook>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<LogCategory> LogCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<LogSubCategory> LogSubCategories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LogBook> LogBooks { get; set; }
    }
}
