using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Models
{
    public class Departments
    {
        public int ID { get; set; }
        //[DisplayName("Department Name")]
        public string Name { get; set; }
        public double Budget { get; set; }
        public DateTime StartDate { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public int RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
