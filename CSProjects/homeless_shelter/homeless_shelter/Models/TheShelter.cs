using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homeless_shelter.Models
{
    public class TheShelter
    {
        public List<Person> roster { get; set;}
    }
    public class Person
    {
        public string Name;
    }
    
}