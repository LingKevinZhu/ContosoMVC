using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public class ContosoDBContext:DbContext
    {
        public ContosoDBContext(): base("name=ContosoDB")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<People> People { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<OfficeAssignments> OfficeAssignments { set; get; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
    }
}
