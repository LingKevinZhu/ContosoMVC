using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoMVC.ViewModel
{
    public class DepartmentCourseViewModel
    {
        public int CourseID { get; set; }
        public int DepartmentID { get; set; }
        public string CourseName { get; set; }
        public string DepartmentName { get; set; }
        public decimal DepartmentBudget { get; set; }
    }
}