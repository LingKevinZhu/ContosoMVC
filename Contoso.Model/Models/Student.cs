using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Models
{
    public class Student
    {
        [Key]
        [ForeignKey("People")]
        public int ID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public People People { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
