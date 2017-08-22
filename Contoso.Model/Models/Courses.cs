using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Models
{
    public class Courses
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        [ForeignKey("Departments")]
        public int DepartmentsID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Departments Departments { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
