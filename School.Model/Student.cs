using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Student
    {
        [Key]
        public string StdID { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
    }
}
