using System;

namespace RockDeckWins
{
public class RPSCode
{
  static void Main()
  {
    Console.WriteLine("Hello World!");
    Console.WriteLine("Player One Make your move!");
    string InputOne = Console.ReadLine();
    Console.WriteLine("Wow what a good choice player 2 dont read it now make your move");
    string InputTwo = Console.ReadLine();



    RPSCode rpsCode = new RPSCode();
    string result = rpsCode.Match(InputOne, InputTwo);
    Console.WriteLine(result);
    //Match(InputOne, InputTwo);
    // C# Program code goes here.
  }
  public string Match(string a, string b)
  {
    a = a.Trim();
    b = b.Trim();
    a = a.ToLower();
    b = b.ToLower();
    if(a == "rock" || a == "paper" || a == "scissors")
    { 
      if(b == "rock" || b == "paper" || b == "scissors")
      {
        if(a == b)
        {
          Console.WriteLine("Tie! Do it again nerds");
          return "tie";
        }
        else if(a == "rock" && b == "paper")
        {
          Console.WriteLine("Player 2 wins. Somehow I'm not suprised");
          return "P2W";
        }
        else if(a == "rock" && b == "scissors")
        {
          Console.WriteLine("Player 1 wins. Player 2 seems dull, LIKE THE SCISSORS THEY PICKED!");
          return "P1W";
        }
        else if(a == "paper" && b == "rock")
        {
          Console.WriteLine("Player 1 wins. Player 2 seemingly have rocks for brains");
          return "P1W";
        }
        else if(a == "paper" && b == "scissors")
        {
          Console.WriteLine("Player 1 wins..... JK, Player 2 wins.");
          return "P2W";
        }
        else if(a == "scissors" && b == "paper")
        {
          Console.WriteLine("Player 1 wins. Player 2 seemingly is a wet noodle.");
          return "P1W";
        }
        else if(a == "scissors" && b == "rock")
        {
          Console.WriteLine("Player 2 wins. GG I guess.");
          return "P2W";
        }
        else{
          Console.WriteLine("how did you both manage this?");
          return "literally how?";
        }
      }
      else
      {
        Console.WriteLine("Thats not a valid move how are you this bad at rock paper scissors its a game for babies");
        return "Utter failure";
      }
    }
    else
    {
      Console.WriteLine("Thats not a valid move how are you this bad at rock paper scissors its a game for babies");
      return "Utter failure";
    }

    // C# Program code goes here.
  }
}
}
