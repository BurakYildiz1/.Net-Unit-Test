using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using webdenemeunit.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AboutHakkinda()
        {
            //arrange
            HomeController controller = new HomeController();
            //act
            ViewResult sonuc = controller.About() as ViewResult;
            //assert
            Assert.AreEqual("bizim mesajımız", sonuc.ViewBag.Message);
        }
    }
}
