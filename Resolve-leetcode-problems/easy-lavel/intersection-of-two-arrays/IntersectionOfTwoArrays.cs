using System;

public class Solution
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        return nums1.Intersect(nums2).ToArray();
    }

    public static void Main(string[] args)
    {
        int[] nums1 = [4, 9, 5];
        int[] nums2 = [9, 4, 9, 8, 4];
        foreach (int i in nums1) Console.Write(i);

        Console.WriteLine();
        foreach (int i in nums2) Console.Write(i);

        Console.WriteLine();
        foreach (int i in Intersection(nums1, nums2)) Console.Write(i);
    }
}
