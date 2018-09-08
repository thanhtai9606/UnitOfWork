using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
   public  class Enrollment
    {
       [Key]
       public string EnrollID { set; get; }
       public DateTime RegisterDate { set; get; }
       public string StdID { set; get; }
       public string CourseID { set; get; }
    }
}
