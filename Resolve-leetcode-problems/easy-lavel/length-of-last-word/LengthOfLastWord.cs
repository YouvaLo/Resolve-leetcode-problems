using System;
public class Solution
{
   public static int LengthOfLastWord(string s)
   {
      // example --> s = " Hello World " --> s.Trim() = "Hello World"
      // s.Trim().Split(' ') = ["Hello", "World"] 
      var tab = s.Trim().Split(' ');
      var length = tab.Length;
      return tab[length-1].Length;
   }

   public static void Main()
   {
      var s = "   Bonjour   les   amis  ";
      Console.WriteLine($"The length of the last word is : {LengthOfLastWord(s)}");
   }
}