using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JanKenPon.Models;
using System;

namespace JanKenPon.Tests
{
  [TestClass]
  public class JanKenPonTest
  {
    [TestMethod]
    public void Player1Set_IsRock_False()
    {
      JanKenPonGame newJan = new JanKenPonGame();
      newJan.SetPlayer1JKP("Scissor");
      string janOutput = newJan.GetPlayer1JKP();
      Assert.AreEqual("Rock", janOutput);
    }

    [TestMethod]
    public void Player1Set_IsRock_True()
    {
      JanKenPonGame newJan = new JanKenPonGame();
      newJan.SetPlayer1JKP("Rock");
      string janOutput = newJan.GetPlayer1JKP();
      Assert.AreEqual("Rock", janOutput);
    }

  }
}
