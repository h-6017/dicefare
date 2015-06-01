using System;
using homeless_shelter.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homeless_shelter.Controllers
{
    public enum State
    {
        Add,
        Remove,
        List
    }
    public class HomeController : Controller
    {

        static TheShelter dCCShelter;
        public ActionResult GetView(string i)
        {
            State s = new State();
            if (i == "0")
            {
                s = State.Add;
            }
            else if (i == "1")
            {
                s = State.Remove;
            }
            else if (i == "2")
            {
                s = State.List;
            }
            switch (s)
            {
                case State.Add:
                    return Add();
                case State.Remove:
                    return Remove();
                case State.List:
                    return List();
                default:
                    return List();
            }
        }

        private void Init()
        {
            if (dCCShelter == null)
            {
                dCCShelter = new TheShelter();
            }
        }
            
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Add()
        {
            ViewBag.Message = "Add a new person to the homeless shelter.";

            return View("Add");
        }
        public ActionResult Remove()
        {
            ViewBag.Message = "Remove an existing person to the homeless shelter.";

            return View();
        }
        public ActionResult List()
        {
            ViewBag.Message = "A list of all the people currently in this homeless shelter.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public void AddPerson(string name)
        {
            Person person = new Person();
            person.Name = name;

            dCCShelter.roster.Add(person);
        }
    }
}