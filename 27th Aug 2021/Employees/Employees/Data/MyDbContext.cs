using Employees.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Data
{
    public class MyDbContext : IdentityDbContext<EmployeeUser>
    {
            public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
            {
               
            }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            builder.Entity<Skills>().HasIndex(b => b.SkillName).IsUnique();

            //builder.Entity<Skills>().HasMany(d => d.Details)
            //   .WithOne(e => e.Skill)
            //   .HasForeignKey(e => e.SkillId);

            builder.Entity<EmployeeDetail>()
            .HasOne<Skills>(s => s.Skills)
            .WithMany(g => g.Details)
            .HasForeignKey(s => s.SkillId);

            base.OnModelCreating(builder);

        }

        public DbSet<EmployeeDetail> employee { get; set; }

            public DbSet<Skills> skill { get; set; }

        
           
            //base.OnModelCreating(builder);
       
    }
}
