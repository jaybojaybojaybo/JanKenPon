using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JanKenPon.Controllers;
using JanKenPon.Models;

namespace JanKenPon.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      HomeController controller = new HomeController();
      IActionResult indexView = controller.Index();
      ViewResult result = indexView as ViewResult;
      Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod]
    public void Index_HasCorrectModelType_WinnerMessage()
    {
      HomeController controller = new HomeController();
      IActionResult ActionResult = controller.Index();
      ViewResult indexView = controller.Index() as ViewResult;
      var result = indexView.ViewData.Model;
      Assert.IsInstanceOfType(result);
    }
  }
}
