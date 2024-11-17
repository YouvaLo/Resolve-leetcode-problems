using System;

public class Solution
{
    public static int MissingNumber(int[] nums)
    {
            var missingNumber = 0;

            for (int i = 0; i <= nums.Length; i++)
            {
                if (!nums.Contains(i)) missingNumber = i;
            }

            return missingNumber;
    }

    public static void Main(string[] args)
    {
            int[] nums = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            var missingNumber = MissingNumber(nums);

            Console.WriteLine($"The missing number is : {missingNumber}");
    }
}