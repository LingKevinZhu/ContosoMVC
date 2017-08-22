using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model.Models;

namespace Contoso.Service
{
    public class CourseService
    {
        public List<Courses> GetAllCourses()
        {
            CourseRepository courseRepository = new CourseRepository();
            var course = courseRepository.GetAll();
            return course;
        }
        public void AddCourses(Courses entity)
        {
            CourseRepository courseRepository = new CourseRepository();
            //DepartmentRepository departmentsRepository = new DepartmentRepository();
            //Departments departments = departmentsRepository.GetByID(entity.DepartmentsID);
            //entity.Departments = departments;
            courseRepository.Add(entity);
        }
        public Courses GetOneCourses(int id)
        {
            CourseRepository coursesRepository = new CourseRepository();
            return coursesRepository.GetByID(id);
        }
        public void DeleteCourses(int id)
        {
            CourseRepository coursesRepository = new CourseRepository();
            Courses obj = coursesRepository.GetByID(id);
            coursesRepository.Delete(obj);
        }
        public void UpdateCourses(Courses entity)
        {
            CourseRepository coursesRepository = new CourseRepository();
            coursesRepository.Update(entity);
        }

    }
}
