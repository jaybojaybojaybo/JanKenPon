using System.Collections.Generic;
using System;
using System.Windows.Input.Key;


namespace JanKenPon.Models
{
  public class JanKenPon
  {
    public string player1JKP;
    public string player2JKP;
    public bool winState;
    private KeyboardState oldState;

    public string GetPlayer1JKP()
    {
      return player1JKP;
    }

    public void SetPlayer1JKP(string selection)
    {
      if(bool CKeyDown = state.IsKeyDown(Keys.C))
      {
        selection = "Rock";
      }
      else if(bool DKeyDown = state.IsKeyDown(Keys.D))
      {
        selection = "Paper";
      }
      else if(bool EKeyDown = state.IsKeyDown(Keys.E))
      {
        selection = "Scissors";
      }
      player1JKP = selection;
    }

    public string GetPlayer2JKP()
    {
      return player2JKP;
    }

    public void SetPlayer2JKP(string selection)
    {
      if(bool CKeyDown = state.IsKeyDown(Keys.C))
      {
        selection = "Rock";
      }
      else if(bool DKeyDown = state.IsKeyDown(Keys.D))
      {
        selection = "Paper";
      }
      else if(bool EKeyDown = state.IsKeyDown(Keys.E))
      {
        selection = "Scissors";
      }
      player2JKP = selection;
    }

    public bool GetWinState();
    {
      return winState;
    }

    public void SetWinState(bool winner);
    {
      if(player1JKP == "Rock" && player2JKP == "Scissors")
      {
        winner = true;
      }
      else if(player1JKP == "Paper" && player2JKP == "Rock")
      {
        winner = true;
      }
      else if(player1JKP == "Scissors" && player2JKP == "Paper")
      {
        winner = true;
      }
      else if(player2JKP == "Rock" && player1JKP == "Scissors")
      {
        winner = false;
      }
      else if(player2JKP == "Paper" && player1JKP == "Rock")
      {
        winner = false;
      }
      else if(player2JKP == "Scissors" && player1JKP == "Paper")
      {
        winner = false;
      }
      winState = winner;
    }

    private static class Keyboard()
    {
      KeyboardState newState = Keyboard.GetState();
      if (bool CKeyDown = state.IsKeyDown(Keys.C))
      {
        player1JKP = "Rock";
      }
      //   bool DKeyDown = state.IsKeyDown(Keys.C);
      //   bool EKeyDown = state.IsKeyDown(Keys.C);
      //   bool MKeyDown = state.IsKeyDown(Keys.C);
      //   bool KKeyDown = state.IsKeyDown(Keys.C);
      //   bool OKeyDown = state.IsKeyDown(Keys.C);
      // }
    }
  }
}
