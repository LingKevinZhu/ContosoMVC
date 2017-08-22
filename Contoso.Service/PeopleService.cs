using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model.Models;

namespace Contoso.Service
{
    public class PeopleService
    {
        public List<People> GetAllPeople()
        {
            PeopleRepository peopleRepository = new PeopleRepository();
            var people = peopleRepository.GetAll();
            return people;
        }
        public void AddPeople(People entity)
        {
            PeopleRepository peopleRepository = new PeopleRepository();
            peopleRepository.Add(entity);
        }
        public People GetOnePeople(int id)
        {
            PeopleRepository peopleRepository = new PeopleRepository();
            return peopleRepository.GetByID(id);
        }
        public void DeletePeople(int id)
        {
            PeopleRepository peopleRepository = new PeopleRepository();
            People obj = peopleRepository.GetByID(id);
            peopleRepository.Delete(obj);
        }
        public void UpdatePeople(People entity)
        {
            PeopleRepository peopleRepository = new PeopleRepository();
            peopleRepository.Update(entity);
        }

    }
}
