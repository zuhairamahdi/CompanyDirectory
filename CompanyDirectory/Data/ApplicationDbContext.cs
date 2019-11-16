using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanyDirectory.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<Department> Department { get; set; }
        DbSet<Employee> Employee { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
