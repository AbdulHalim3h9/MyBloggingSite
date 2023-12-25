using MBS.Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Infrastructure.DbContexts
{
    public class BlogDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Blog> Blogs { get; set; }
        //public BlogDbContext(DbContextOptions<BlogDbContext> options)
        //    : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-MBS.Web-e96c3ddc-91b6-40ac-89e0-12a4ff31b2a9;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
