using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Models;

namespace Contoso.Data
{
    public class DepartmentRepository : IRepository<Departments>
    {
        public void Add(Departments entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.Departments.Add(entity);
                contosoDbContext.SaveChanges();
            }
        }

        public void Delete(Departments entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                var departments = contosoDbContext.Departments.ToList();
                var department = departments.SingleOrDefault(d => d.ID == entity.ID);
                if (department != null)
                {
                    contosoDbContext.Departments.Remove(department);
                    contosoDbContext.SaveChanges();
                }
            }
        }

        public List<Departments> GetAll()
        {
            ContosoDBContext contosoDbContext = new ContosoDBContext();
            return contosoDbContext.Departments.ToList();
        }

        public Departments GetByID(int id)
        {
            ContosoDBContext contosoDbContext = new ContosoDBContext();
            Departments department= contosoDbContext.Departments.SingleOrDefault(d=>d.ID==id);
            return department;
        }

        public void Update(Departments entity)
        {
            using (var contosoDbContext = new ContosoDBContext())
            {
                contosoDbContext.Departments.Attach(entity);
                contosoDbContext.Entry(entity).State=EntityState.Modified;
                contosoDbContext.SaveChanges();
            }
        }
    }
}
