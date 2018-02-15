using System.Collections.Generic;
using System;

namespace JanKenPon.Models
{
  public class JanKenPonGame
  {
    private string _player1JKP;
    private string _player2JKP;
    private bool winState;


    public string GetPlayer1JKP()
    {
      return _player1JKP;
    }

    public void SetPlayer1JKP(string selection)
    {
      string player1 = "";
      if(selection == "c")
      {
        player1 = "Rock";
      }
      else if(selection == "d")
      {
        player1 = "Paper";
      }
      else if(selection == "e")
      {
        player1 = "Scissors";
      }
      _player1JKP = player1;
    }

    public string GetPlayer2JKP()
    {
      return _player2JKP;
    }

    public void SetPlayer2JKP(string selection)
    {
      string player2 = "";
      if(selection == "m")
      {
        player2 = "Rock";
      }
      else if(selection == "k")
      {
        player2 = "Paper";
      }
      else if(selection == "o")
      {
        player2 = "Scissors";
      }
      _player2JKP = player2;
    }

    public bool GetWinState()
    {
      return winState;
    }

    public void SetWinState(string player1, string player2)
    {
      bool winner = false;
      if(_player1JKP == "Rock" && _player2JKP == "Scissors")
      {
        winner = true;
      }
      else if(_player1JKP == "Paper" && _player2JKP == "Rock")
      {
        winner = true;
      }
      else if(_player1JKP == "Scissors" && _player2JKP == "Paper")
      {
        winner = true;
      }
      else if(_player2JKP == "Rock" && _player1JKP == "Scissors")
      {
        winner = false;
      }
      else if(_player2JKP == "Paper" && _player1JKP == "Rock")
      {
        winner = false;
      }
      else if(_player2JKP == "Scissors" && _player1JKP == "Paper")
      {
        winner = false;
      }
      winState = winner;
    }
  }
}
