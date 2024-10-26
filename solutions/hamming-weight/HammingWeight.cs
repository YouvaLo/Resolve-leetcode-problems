using System.Numerics;

class program
{
   //base10 to base2 conversion : by Division 
    public static string IntegerToBinary(int a)
    {
        if (a == 0) return "0";
        var sA = "";
        while (a > 0)
        {
            sA = (a % 2) + sA;
            a = a / 2;
        }

        return sA;
    }

    public static int HammingWeight(int n)
    {
        var numberOfSetBits = 0;
        var tabN = IntegerToBinary(n);
        
        foreach (var tn in tabN) numberOfSetBits += int.Parse(tn.ToString());

        return numberOfSetBits;
    }

    public static void Main(string[] args)
    {
        int n = 128;
        Console.WriteLine($"Number of set bits is {HammingWeight(n)}");  
    }
}
