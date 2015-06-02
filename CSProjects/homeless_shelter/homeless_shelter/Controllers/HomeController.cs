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
            if (dCCShelter.roster == null)
            {
                dCCShelter.roster = new List<Person>();
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
            Person person = new Person();

            ViewBag.Message = "Add a new person to the homeless shelter.";
            ViewResult rs = View("Add", person);
            return rs;

        }
        public ActionResult Remove()
        {
            Init();
            ViewBag.Message = "Remove an existing person from the homeless shelter.";

            return View("Remove", dCCShelter);
        }
        public ActionResult RemovePerson(string name)
        {
            //Init();

            dCCShelter.roster = dCCShelter.roster.Where(e => !e.Name.Equals(name)).ToList();

            return View("List", dCCShelter);
            //dCCShelter.roster = dCCShelter.roster.Where(per => per.Name == name).ToList();
            

        }
        public ActionResult List()
        {
            Init();
            ViewBag.Message = "A list of all the people currently in this homeless shelter.";

            return View("List", dCCShelter);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddPerson(string name)
        {
            Init();
            Person person = new Person();
            person.Name = name;

            dCCShelter.roster.Add(person);
            return View("List", dCCShelter);
        }
    }
}