using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Model.Models
{
    public class Instructor
    {
        [Key]
        [ForeignKey("People")]
        public int ID { get; set; }
        public DateTime HireDate { get; set; }
        public People People { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Courses> Courses { get; set; }
    }
}
