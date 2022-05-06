using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Controllers;
using OnlineShop;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace TestsCode
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

            //Assert

        }

        public void Privacy()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Privacy() as ViewResult;
            Assert.IsNotNull (result);
        }
        

        }

    }
