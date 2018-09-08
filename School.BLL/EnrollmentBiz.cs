using School.Contact;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL
{
    public class EnrollmentBiz : Repository<Enrollment>, IEnrollment
    {
        public EnrollmentBiz(SchoolContext context) : base(context) { }

        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}
