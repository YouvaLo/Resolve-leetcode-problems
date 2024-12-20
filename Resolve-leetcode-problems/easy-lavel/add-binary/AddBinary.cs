using System;
using System.Numerics;

public class Solution
{
    //Base2 to Base10 conversion 
    public static BigInteger BinaryToInteger(string a)
    {
        BigInteger iA = 0;
        BigInteger powerOf2 = 1;

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == '1') iA += powerOf2;
            //shift right by 1 example: 10 << 1 = 100
            if (i > 0) powerOf2 <<= 1;
        }

        return iA;
    }    

    //base10 to base2 conversion : by Division 
    public static string IntegerToBinary(BigInteger a)
    {
        if (a == 0) return "0";
        var sA = "";
        while(a > 0)
        {
            sA = (a % 2) + sA;
            a = a / 2;
        }

        return sA;
    }

    public static string AddBinary(string a, string b)
    {
        var iA = BinaryToInteger(a);
        var iB = BinaryToInteger(b);

        var add = (iA + iB);

        return IntegerToBinary(add);
    }

    public static void Main(string[] args)
    {
        var a = "11";
        Console.WriteLine("a = " + a);

        var b = "111";
        Console.WriteLine("b = " + b);

        Console.WriteLine($"Binary addition of a + b équals to : {AddBinary(a, b)}");
    }
}
