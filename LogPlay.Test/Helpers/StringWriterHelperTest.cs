using LogPlay.Helpers;
using LogPlay.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogPlay.Test.Helpers
{
    [TestFixture]
    public class StringWriterHelperTest
    {

        [Test]
        public void Resolve()
        {
            //Arrange 
            var person = new Person() { FirstName = "Ash", Surname = "Kilgour" };
            //Act  
            var value = StringWriterHelper.Resolve(person);
            //Assert
            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Id>0</Id>\r\n  <FirstName>Ash</FirstName>\r\n  <Surname>Kilgour</Surname>\r\n  <CreatedOn>0001-01-01T00:00:00</CreatedOn>\r\n  <Active>false</Active>\r\n</Person>", value);
        }
    }
}
