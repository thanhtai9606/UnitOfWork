using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Contact
{
    public interface IStudent:IRepository<Student>
    {
        string GetInfo();
       
    }
}
