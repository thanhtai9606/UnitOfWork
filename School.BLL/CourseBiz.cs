using School.Contact;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL
{
   public class CourseBiz: Repository<Course>,ICourse
    {
       public CourseBiz(SchoolContext context) : base(context) { }
    }
}
