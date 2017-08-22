using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contoso.Model.Models;
using Contoso.Service;
using Contoso.Utitlity;

namespace ContosoMVC.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult ListCourses()
        {
            CourseService courseService = new CourseService();
            List<Courses> list = courseService.GetAllCourses();
            return View(list);
        }

        [HttpPost]
        public ActionResult DeleteCourse(Courses course)
        {
            CourseService courseService = new CourseService();
            courseService.DeleteCourses(course.ID);
            return RedirectToAction("ListCourses");
        }

        public ActionResult DeleteCourse(int ID)
        {
            CourseService courseService = new CourseService();
            var course = courseService.GetOneCourses(ID);
            return View(course);
        }

        [HttpPost]
        public ActionResult EditCourse(Courses course)
        {
            CourseService courseService = new CourseService();
            courseService.UpdateCourses(course);
            return RedirectToAction("ListCourses");
        }

        public ActionResult EditCourse(int ID)
        {
            //var list = Utility.GetAllDepartments();
            //ViewBag.Departments = new SelectList(list, "ID", "ID");
            CourseService courseService = new CourseService();
            var course = courseService.GetOneCourses(ID);
            return View(course);
        }


        public ActionResult AddCourse()
        {
            //var list = Utility.GetAllDepartments();
            //ViewBag.Departments = new SelectList(list, "ID", "ID");
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(Courses course)
        {
            CourseService courseService = new CourseService();
            courseService.AddCourses(course);
            return RedirectToAction("ListCourses");
        }

        public ActionResult DetailsCourse(int ID)
        {
            CourseService courseService = new CourseService();
            var course = courseService.GetOneCourses(ID);
            return View(course);
        }
    }
}