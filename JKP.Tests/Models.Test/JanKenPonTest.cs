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

    [TestMethod]
    public void Player2Set_IsRock_False()
    {
      JanKenPonGame newKen = new JanKenPonGame();
      newKen.SetPlayer2JKP("Scissor");
      string kenOutput = newKen.GetPlayer2JKP();
      Assert.AreEqual("Rock", kenOutput);
    }

    [TestMethod]
    public void Player2Set_IsRock_True()
    {
      JanKenPonGame newKen = new JanKenPonGame();
      newKen.SetPlayer2JKP("Rock");
      string kenOutput = newKen.GetPlayer2JKP();
      Assert.AreEqual("Rock", kenOutput);
    }

    [TestMethod]
    public void SetWinState_Player1Wins_True()
    {
      JanKenPonGame newPon = new JanKenPonGame();
      newPon.SetPlayer1JKP("Rock");
      newPon.SetPlayer2JKP("Scissors");
      string player1Pon = newPon.GetPlayer1JKP();
      string player2Pon = newPon.GetPlayer2JKP();
      newPon.SetWinState(player1Pon, player2Pon);
      bool winnerDecision = newPon.GetWinState();
      Assert.AreEqual(true, winnerDecision);
    }

  }
}
