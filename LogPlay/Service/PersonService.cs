using LogPlay.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LogPlay.Models;
using LogPlay.Logging.Interface;

namespace LogPlay.Service
{
    public class PersonService : IPersonService
    {
        private readonly IXeretecLogging _logging;

        public PersonService(IXeretecLogging logging)
        {
            _logging = logging;
        }

        public Person GetPersonById(int personId)
        {
            _logging.Entering();
            var person = new Person() { Id = personId, FirstName = "Billy", Surname = "Shears", Active = true, CreatedOn = DateTime.Now };
            _logging.Exiting(person);
            return person;
        }
    }
}