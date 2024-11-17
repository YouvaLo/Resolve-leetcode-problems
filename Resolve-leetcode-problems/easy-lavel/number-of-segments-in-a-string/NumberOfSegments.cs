public class Solution
{
   public static int CountSegments(string s)
   {
      //Split and Remove Empty Entries (White Spaces)   
      var numberOfSegments = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
      return numberOfSegments;
   }

   public static void Main(string[] args)
   {
      //Expected : numberOfSegments = 3 ("Hello", "World" and "!")
      var s = " Hello World   !";
      Console.WriteLine("Number of Segments is : " + CountSegments(s));
   }
}
