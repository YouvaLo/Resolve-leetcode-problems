using System;

public class Solution
{
    public static bool IsPowerOfThree(int n)
    {
            //log3(n) = ln(n) / ln(3)
            //The neperian logarithm or the Natural logarithm
            var logInBase3 = Math.Log(n) / Math.Log(3);

            //Declare a tolerance(precision)
            //10 digits after the decimal point
            double epsilon = 1e-10;

            //Sometimes division returns an approximation
            if (Math.Abs(logInBase3 - Math.Round(logInBase3)) < epsilon)
                logInBase3 = Math.Round(logInBase3);

            if ((logInBase3 - Math.Truncate(logInBase3)) != 0) return false;

            return true;
    }

    public static void Main(string[] args)
    {
            int n1 = 27;
            int n2 = 1162261467;
            int n3 = 10;
            Console.WriteLine($"{n1} is power of 3 : {IsPowerOfThree(n1)}");
            Console.WriteLine($"{n2} is power of 3 : {IsPowerOfThree(n2)}");
            Console.WriteLine($"{n3} is power of 3 : {IsPowerOfThree(n3)}");
    }
}