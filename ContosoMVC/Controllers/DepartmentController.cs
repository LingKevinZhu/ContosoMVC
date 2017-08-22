using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model.Models;
using Contoso.Service;
using Contoso.Utitlity;
using ContosoMVC.Filters;
using ContosoMVC.ViewModel;

namespace ContosoMVC.Controllers
{
    //[LogActionFilter]
    [HandleError]
    public class DepartmentController : Controller
    {
        //public DepartmentController()
        //{
        //    int i = 0, x = 1;
        //    int z = x / i;
        //}
        // GET: Department

        public ActionResult ListDepartment()
        {
            DepartmentService departmentService=new DepartmentService();
            List<Departments> list = departmentService.GetAllDepartments();
            return View(list);
        }

        [HttpPost]
        public ActionResult DeleteDepartment(Departments department)
        {
            DepartmentService departmentService=new DepartmentService();
            departmentService.DeleteDepartments(department.ID);
            return RedirectToAction("ListDepartment");
        }

        public ActionResult DeleteDepartment(int ID)
        {
            DepartmentService departmentService=new DepartmentService();
            var department = departmentService.GetOneDepartments(ID);
            return View(department);
        }

        [HttpPost]
        public ActionResult EditDepartment(Departments department)
        {
            DepartmentService departmentService=new DepartmentService();
            departmentService.UpdateDepartments(department);
            return RedirectToAction("ListDepartment");
        }

        public ActionResult EditDepartment(int ID)
        {
            //var list = Utility.GetAllInstructors();
            //ViewBag.Instructors = new SelectList(list, "ID", "ID");
            DepartmentService departmentService=new DepartmentService();
            var department = departmentService.GetOneDepartments(ID);
            return View(department);
        }


        public ActionResult AddDepartment()
        {
            //var list = Utility.GetAllInstructors();
            //ViewBag.Instructors = new SelectList(list, "ID", "ID");
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Departments department)
        {
            DepartmentService departmentService=new DepartmentService();
            departmentService.AddDepartments(department);
            return RedirectToAction("ListDepartment");
        }

        public ActionResult DetailsDepartment(int ID)
        {
            DepartmentService departmentService = new DepartmentService();
            var department=departmentService.GetOneDepartments(ID);
            return View(department);
        }

        public ActionResult CreateDepartmentAndCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDepartmentAndCourse(DepartmentCourseViewModel model)
        {
            DepartmentService departmentService=new DepartmentService();
            Departments department=new Departments();
            department.Name = model.DepartmentName;
            department.Budget = Convert.ToDouble(model.DepartmentBudget);
            departmentService.AddDepartments(department);

            CourseService courseService=new CourseService();
            Courses course=new Courses();
            course.Title = model.CourseName;
            courseService.AddCourses(course);

            return View();
        }
    }
}