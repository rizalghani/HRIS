using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRIS.Models
{
    public class HRISDBContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public HRISDBContext(DbContextOptions<HRISDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => new { e.EmpID });
        }
    }
}
