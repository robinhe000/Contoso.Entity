using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext
    {
        //optimal for base()
        public ContosoDbContext() : base("name = ContosoDbContext")
        {

        }
        public DbSet<People> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
