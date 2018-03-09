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
        public void ResolvePerson()
        {
            //Arrange 
            var person = new Person() { FirstName = "Ash", Surname = "Kilgour" };
            //Act  
            var value = StringWriterHelper.Resolve(person);
            //Assert
            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<Person xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Id>0</Id>\r\n  <FirstName>Ash</FirstName>\r\n  <Surname>Kilgour</Surname>\r\n  <CreatedOn>0001-01-01T00:00:00</CreatedOn>\r\n  <Active>false</Active>\r\n</Person>", value);
        }

        [Test]
        public void ResolveSalesOrder()
        {
            //Arrange 
            var saleOrderItemOne = new SalesOrderItem() { Cost = 1, Description = "One" };
            var saleOrderItemTwo = new SalesOrderItem() { Cost = 2, Description = "Two" };
            var saleOrder = new SalesOrder() { OrderId = "3a", SalesOrderItems = new List<SalesOrderItem>() { saleOrderItemOne, saleOrderItemTwo } };
            //Act  
            var value = StringWriterHelper.Resolve(saleOrder);
            //Assert
            Assert.AreEqual("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<SalesOrder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <OrderId>3a</OrderId>\r\n  <SalesOrderItems>\r\n    <SalesOrderItem>\r\n      <Description>One</Description>\r\n      <Cost>1</Cost>\r\n    </SalesOrderItem>\r\n    <SalesOrderItem>\r\n      <Description>Two</Description>\r\n      <Cost>2</Cost>\r\n    </SalesOrderItem>\r\n  </SalesOrderItems>\r\n</SalesOrder>", value);
        }
    }
}
