using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Models;

namespace Contoso.Data
{
    public class CourseRepository : IRepository<Courses>
    {
        public void Add(Courses entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.Courses.Add(entity);
                contosoDbContext.SaveChanges();
            }
        }

        public void Delete(Courses entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                var courses = contosoDbContext.Courses.ToList();
                var course = courses.SingleOrDefault(d => d.ID == entity.ID);
                if (course != null)
                {
                    contosoDbContext.Courses.Remove(course);
                    contosoDbContext.SaveChanges();
                }
            }
        }

        public List<Courses> GetAll()
        {
            ContosoDBContext contosoDbContext=new ContosoDBContext();
            return contosoDbContext.Courses.ToList();
        }

        public Courses GetByID(int id)
        {
            ContosoDBContext contosoDbContext = new ContosoDBContext();
            Courses course = contosoDbContext.Courses.SingleOrDefault(d => d.ID == id);
            return course;
        }

        public void Update(Courses entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.Courses.Attach(entity);
                contosoDbContext.Entry(entity).State = EntityState.Modified;
                contosoDbContext.SaveChanges();
            }
        }
    }
}
