using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JanKenPon.Models;
using System;

namespace JanKenPon.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/TheFists")]
      public ActionResult TheFists()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult Winner()
      {
        JanKenPonGame newGame = new JanKenPonGame();
        newGame.SetPlayer1JKP(Request.Form["player1"]);
        newGame.SetPlayer2JKP(Request.Form["player2"]);
        string player1choice = newGame.GetPlayer1JKP();
        string player2choice = newGame.GetPlayer2JKP();
        newGame.SetWinState(player1choice, player2choice);
        bool winner = newGame.GetWinState();
        if(winner == true)
        {
          return View("TheFists","Player1 Wins!");
        }
        else
        {
          return View("TheFists", "Player2 Wins!");
        }
      }
    }
}
