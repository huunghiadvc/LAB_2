using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_2.model
{
    public class Person
    {
        public string? Name { get; set; }
        public string? BirthDay { get; set; }
        public string? CitizenId { get; set; }
        public Person(string Name, string BirthDay, string CitizenId)
        {
            this.Name = Name;
            this.BirthDay = BirthDay;
            this.CitizenId = CitizenId;
        }
    }
}