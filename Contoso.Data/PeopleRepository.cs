using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Models;

namespace Contoso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        public void Add(People entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.People.Add(entity);
                contosoDbContext.SaveChanges();
            }
        }

        public void Delete(People entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                var people = contosoDbContext.People.ToList();
                var person = people.SingleOrDefault(d => d.ID == entity.ID);
                if (person != null)
                {
                    contosoDbContext.People.Remove(person);
                    contosoDbContext.SaveChanges();
                }
            }
        }

        public List<People> GetAll()
        {
            ContosoDBContext contosoDbContext = new ContosoDBContext();
            return contosoDbContext.People.ToList();
        }

        public People GetByID(int id)
        {
            ContosoDBContext contosoDbContext = new ContosoDBContext();
            People person = contosoDbContext.People.SingleOrDefault(d => d.ID == id);
            return person;
        }

        public void Update(People entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.People.Attach(entity);
                contosoDbContext.Entry(entity).State = EntityState.Modified;
                contosoDbContext.SaveChanges();
            }
        }
    }
}
