using System;

public class Solution
{
    public static bool IsPowerOfFour(int n)
    {
        //Base4(n) = ln(n) / ln(4)
        var logInBase4 = Math.Log(n) / Math.Log(4);

        //Check decimal part if equal to 0 or not
        if ((logInBase4 - Math.Truncate(logInBase4)) != 0) return false;

        return true;
    }

    public static void Main(string[] args)
    {
        int n1 = 16;
        int n2 = 5;
        int n3 = 10;
        Console.WriteLine($"{n1} is power of 4 : {IsPowerOfFour(n1)}");
        Console.WriteLine($"{n2} is power of 4 : {IsPowerOfFour(n2)}");
        Console.WriteLine($"{n3} is power of 4 : {IsPowerOfFour(n3)}");
    }
}