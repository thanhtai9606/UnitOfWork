using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL
{
    public class SchoolContext: DbContext
    {
         public SchoolContext()
            : base("name=School")
        { }
        public DbSet<Student> Students { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Enrollment> Enrollments { set; get; }
       
    }
}
