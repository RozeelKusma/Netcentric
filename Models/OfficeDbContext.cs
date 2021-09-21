using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace officenet.Models
{
    public class OfficeDbContext: DbContext
    {
        public OfficeDbContext(DbContextOptions<OfficeDbContext>options): base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
