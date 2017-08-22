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
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult ListPeople()
        {
            PeopleService peopleService=new PeopleService();
            List<People> list = peopleService.GetAllPeople();
            return View(list);
        }

        [HttpPost]
        public ActionResult DeletePeople(People person)
        {
            PeopleService peopleService = new PeopleService();
            peopleService.DeletePeople(person.ID);
            return RedirectToAction("ListPeople");
        }

        public ActionResult DeletePeople(int ID)
        {
            PeopleService peopleService = new PeopleService();
            var person = peopleService.GetOnePeople(ID);
            return View(person);
        }

        [HttpPost]
        public ActionResult EditPeople(People person)
        {
            PeopleService peopleService = new PeopleService();
            peopleService.UpdatePeople(person);
            return RedirectToAction("ListPeople");
        }

        public ActionResult EditPeople(int ID)
        {
            PeopleService peopleService = new PeopleService();
            var person = peopleService.GetOnePeople(ID);
            //var list = Utility.GetAllStates();
            //ViewBag.States = new SelectList(list, "StateName", "Value");
            return View(person);
        }


        public ActionResult AddPeople()
        {
            //var list = Utility.GetAllStates();
            //ViewBag.States = new SelectList(list, "StateName", "Value");
            return View();
        }

        [HttpPost]
        public ActionResult AddPeople(People person)
        {
            PeopleService peopleService = new PeopleService();
            peopleService.AddPeople(person);
            return RedirectToAction("ListPeople");
        }

        public ActionResult DetailsPeople(int ID)
        {
            PeopleService peopleService = new PeopleService();
            var person = peopleService.GetOnePeople(ID);
            return View(person);
        }
    }
}