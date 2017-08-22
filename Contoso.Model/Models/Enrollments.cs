using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Models
{
    public class Enrollments
    {
        public int ID { get; set; }
        [ForeignKey("Courses")]
        public int CourseID { get; set; }
        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public char Grade { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Student Student { get; set; }
        public Courses Courses { get; set; }
    }
}
