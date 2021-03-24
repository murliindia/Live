using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerNameSpace;
using EmailNameSpace;
using Moq;
using System.Linq;
using CustomerNameSpace;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaveCustomer()
        {
            Customer OBJ = new Customer();
            //Email email = new Email();
            Mock<Email> objEmail = new Mock<Email>();
            objEmail.Setup(x => x.SendMail()).Returns(true);
            bool Result = OBJ.SaveRecord(objEmail.Object);

            //bool Result = OBJ.SaveRecord(email);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void TestNumber()
        {
            Calculation obj = new Calculation();

            string data = obj.Getadata(5, 3);

            Assert.AreEqual("3550", data);

        }

    }
}
