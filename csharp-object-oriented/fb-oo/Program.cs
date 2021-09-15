using System;
using System.Diagnostics;

namespace fb_oo
{
  class Thing
  {
    const int nothing = int.MaxValue;
    public string value;
    public Thing(int i)
    {
      value = i.ToString();
    }
    public Thing(string s)
    {
      value = s;
    }
    public bool IsNumeric()
    {
      int unused;
      return int.TryParse(value, out unused ); 
    }
    public int ToInt() { return IsNumeric() ? int.Parse(value) : nothing; }
    public void SetInt(int v) { value = v.ToString(); }
    public void SetString(string v) { value = v; }
  }
  class Program
  {
    static void init(Thing[] thing)
    {
      for( var i = 0; i < thing.Length; ++i)
        thing[i] = new Thing(i+1);
    }
    static void fizzbuzzify(Thing[] thing)
    {
      foreach(Thing item in thing)
      {
        if (item.ToInt() % 15 == 0)
        {
          item.SetString("FizzBuzz");
        }
      }
    }
    static void fizzify(Thing[] thing)
    {
      foreach (Thing item in thing)
      {
        if (item.ToInt() % 3 == 0)
          item.value = "Fizz";
      }
    }
    static void buzzify(Thing[] thing)
    {
      foreach (Thing item in thing)
      {
        if (item.ToInt() % 5 == 0)
          item.value = "Buzz";
      }
    }
    static void Main(string[] args)
    {
      Thing[] thing = new Thing[100];
      init(thing);
      fizzbuzzify(thing);
      fizzify(thing);
      buzzify(thing);
      //old school (procedural)
      Thing[] old_school = new Thing[100];
      for(int i = 1; i <= 100; i++)
      {
        if (i % 15 == 0)
          old_school[i-1] = new Thing("FizzBuzz");
        else if (i % 5 == 0)
          old_school[i-1] = new Thing("Buzz");
        else if (i % 3 == 0)
          old_school[i-1] = new Thing("Fizz");
        else
          old_school[i-1] = new Thing(i);
      }
      // test
      for(int i = 0; i < 100; i++)
      {
        System.Diagnostics.Debug.Assert( thing[i].value == old_school[i].value );
      }
      //foreach(Thing item in thing)
      for(int i = 0; i < 100; i++)
      {
        Thing item = thing[i];
        string separator = (i+1 < 100) ? " " : "";
        System.Console.Write("{0}{1}", item.value, separator);
      }
      System.Console.WriteLine("\nDone");
    }
  }
}
