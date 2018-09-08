using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
   public class Course
    {
       [Key]
       public string CourseID { set; get; }
       public string CourseName { set; get; }
       public double Price { set; get; }
    }
}
