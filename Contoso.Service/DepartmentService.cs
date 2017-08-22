using Contoso.Data;
using Contoso.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service
{
    public class DepartmentService
    {
        public List<Departments> GetAllDepartments()
        {
            DepartmentRepository departmentsRepository = new DepartmentRepository();
            var departments = departmentsRepository.GetAll();
            return departments;
        }
        public void AddDepartments(Departments entity)
        {
            DepartmentRepository departmentsRepository = new DepartmentRepository();
            //InstructorRepository instructorRepository = new InstructorRepository();
            //Instructor instructor = instructorRepository.GetByID(entity.InstructorID);
            //entity.Instructor = instructor;
            departmentsRepository.Add(entity);
        }
        public Departments GetOneDepartments(int id)
        {
            DepartmentRepository departmentsRepository = new DepartmentRepository();
            return departmentsRepository.GetByID(id);
        }
        public void DeleteDepartments(int id)
        {
            DepartmentRepository departmentsRepository = new DepartmentRepository();
            Departments obj = departmentsRepository.GetByID(id);
            departmentsRepository.Delete(obj);
        }
        public void UpdateDepartments(Departments obj)
        {
            DepartmentRepository departmentsRepository = new DepartmentRepository();
            departmentsRepository.Update(obj);
        }

    }
}
