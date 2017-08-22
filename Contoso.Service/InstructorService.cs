using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model.Models;

namespace Contoso.Service
{
    public class InstructorService
    {
        public List<Instructor> GetAllInstructor()
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            var instructor = instructorRepository.GetAll();
            return instructor;
        }
        public void AddInstructor(Instructor entity)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            PeopleRepository peopleRepository = new PeopleRepository();
            People people = peopleRepository.GetByID(entity.ID);
            entity.People = people;
            instructorRepository.Add(entity);
        }
        public Instructor GetOneInstructor(int id)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            return instructorRepository.GetByID(id);
        }
        public void DeleteInstructor(int id)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            Instructor obj = instructorRepository.GetByID(id);
            instructorRepository.Delete(obj);
        }
        public void UpdateInstructor(Instructor entity)
        {
            InstructorRepository instructorRepository = new InstructorRepository();
            instructorRepository.Update(entity);
        }

    }
}
