using System; 

public class Solution 
{
    public static int[] TwoSum(int[] nums, int target) 
    { 
        //Declare an empty array
        int[] indexesTab = {}; 

        //Comparer l'élement i avec tous les élements j  
        for(int i = 0; i<(nums.Length-1); i++) 
        {
            for(int j = i+1; j<(nums.Length); j++)
            {
                if(nums[i] + nums[j] == target) indexesTab = [i, j];
            }           
        } 

        return indexesTab;
    }

    //Tester le code 
    public static void Main()
    {
        int[] nums = { 1, 2, 3, 6};
        
        var indexesTab = TwoSum(nums, 5);
        
    	foreach(var indexTab in indexesTab) 
		{
        	Console.Write(indexTab);
		}
    }
}
