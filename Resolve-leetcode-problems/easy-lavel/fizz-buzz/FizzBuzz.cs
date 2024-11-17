using System;
using System.Collections.Generic;

public class Program
{
   public static IList<string> FizzBuzz(int n)
   {
      var answer = new List<string>();
      var element = "";

      for (int i = 1; i <= n; i++)
      {
         element = (i % 5 == 0 && i % 3 == 0) ? "FizzBuzz"
            : (i % 3 == 0) ? "Fizz"
            : (i % 5 == 0) ? "Buzz"
            : i.ToString();

         answer.Add(element);
      }

      return answer;
   }

   public static void Main(string[] args)
   {
      int n = 5;
      foreach (var i in FizzBuzz(n)) Console.Write(i + " ");
   }
}
