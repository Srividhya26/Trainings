using EmployeeDetails.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Data
{
    public class MyDbContext : DbContext
    {
        internal IEnumerable<Migrations.Employees> customer;

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<EmployeesDetail> Employee { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = entry.Entity;
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;

                    entity.GetType().GetProperty("DelStatus").SetValue(entity, 'D');
                }
            }

            return base.SaveChanges();
        }

        public DbSet<DepartmentDetails> Department { get; set; }

        
    }
}
