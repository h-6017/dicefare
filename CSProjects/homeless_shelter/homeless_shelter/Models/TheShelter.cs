using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace homeless_shelter.Models
{
    public enum inebriation
    {
        none,
        slight,
    }
    public class TheShelter
    {
        public List<Person> roster { get; set;}
        private void Init()
        {
            if (this.roster == null)
            {
                this.roster = new List<Person>();
            }
        }

        public List<Person> GetResidents()
        {
            Init();
            return this.roster;
        }
    }
    public class Person
    {
        public string Name;
    }
    
}