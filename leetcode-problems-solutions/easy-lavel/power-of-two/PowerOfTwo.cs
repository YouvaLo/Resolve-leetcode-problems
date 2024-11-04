using System;

class program
{
   public static bool IsPowerOfTwo(int n)
   {
      var x = Math.Log2(n);
      if (x - Math.Truncate(x) == 0) return true;
      return false;
   }
   public static void Main(string[] args)
   {
      var n1 = 8;
      var n2 = 9;
      Console.WriteLine($"{n1} is power of two : {IsPowerOfTwo(n1)}");
      Console.WriteLine($"{n2} is power of two : {IsPowerOfTwo(n2)}");
   }
}
