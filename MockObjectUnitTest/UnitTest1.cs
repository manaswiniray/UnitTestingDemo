using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockObjectTesting.Core;
using MockObjectTesting.Controllers;
using MockObjectTesting.Infrastructure;
using Moq;
using Microsoft.Extensions.Logging;


namespace MockObjectUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IGetDataRepository>();
            mock.Setup(person => person.GetNameById(3066)).Returns("Diya");
            
            EmployeeController employeeController=new EmployeeController(mock.Object);
            string result = employeeController.GetNameById(3066);
            Assert.AreEqual("Diya", result);
        }
    }
}