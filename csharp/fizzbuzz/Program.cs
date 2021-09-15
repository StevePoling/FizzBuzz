using System;
using System.Linq;

namespace fizzbuzz
{
  class Program
  {
    static bool isFizzBuzz(int value)
    {
      return (value % 15) == 0;
    }
    static bool isFizz(int value)
    {
      return (value % 3) == 0;
    }
    static bool isBuzz(int value)
    {
      return (value % 5) == 0;
    }
    static string Output(int value)
    {
      if (isFizzBuzz(value))
        return "FizzBuzz";
      else if (isFizz(value))
        return "Fizz";
      else if (isBuzz(value))
        return "Buzz";
      else
        return value.ToString();
    }
    static void Main(string[] args)
    {
      var message = Enumerable.Range(1, 100)
        .Select<int,string>(Output)
        .Aggregate( (phrase, word) => $"{phrase} {word}");
      Console.WriteLine(message);
      Console.WriteLine("Done");
    }
  }
}
