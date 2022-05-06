using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Controllers;
using OnlineShop;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using OnlineShop.Areas.Admin.Controllers;

namespace TestsCode
{
    [TestClass]
    public class ProductTypesControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //arrange
            ProductTypesController controller = new ProductTypesController();
            //Act
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

            //Assert

        }

       


    }

}
