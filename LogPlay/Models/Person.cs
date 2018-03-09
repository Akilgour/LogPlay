using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogPlay.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Active { get; set; }
    }
}