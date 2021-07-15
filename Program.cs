using System;

namespace dice_game
{
  class Program
  {
    static void Main(string[] args)
    {
      var r = new Random();
      var total = 0;
      System.Console.WriteLine("Roll the Dice!");
      System.Console.ReadKey();
      var first = r.Next(1, 6);
      var second = r.Next(1, 6);
      for (int i = 0; i < 3; i++)
      {
        first = r.Next(1, 6);
        second = r.Next(1, 6);

        if (first == second)
        {
          System.Console.WriteLine($"you rolled double {first}, score: 0");
          continue;
        }
        System.Console.WriteLine($"you Rolled a {first}, {second}, score: {first + second}");
        total += first + second;
      }
      System.Console.WriteLine($"Total Score: {total}");
    }
  }
}
