using School.Contact;
using School.Model;
using School.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BLL
{
    public class StudentBiz : Repository<Student>, IStudent
    {
        public StudentBiz(SchoolContext context)
            : base(context)
        { }
        public string GetInfo()
        {
            return "abc";
        }

    
    }
}
