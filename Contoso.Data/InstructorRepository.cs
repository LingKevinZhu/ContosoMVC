using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Models;

namespace Contoso.Data
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public void Add(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            ContosoDBContext contosoDbContext=new ContosoDBContext();
            return contosoDbContext.Instructor.ToList();
        }

        public Instructor GetByID(int id)
        {
            ContosoDBContext contosoDbContext=new ContosoDBContext();
            Instructor instructor = contosoDbContext.Instructor.SingleOrDefault(d => d.ID == id);
            return instructor;
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
