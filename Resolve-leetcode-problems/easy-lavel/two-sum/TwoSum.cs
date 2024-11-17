using System; 

public class Solution 
{
    public static int[] TwoSum(int[] nums, int target) 
    { 
        //Declare an empty array
        int[] indexesTab = {}; 

        //Compare element i with all elements j   
        for(int i = 0; i<(nums.Length-1); i++) 
        {
            for(int j = i+1; j<(nums.Length); j++)
            {
                if(nums[i] + nums[j] == target) indexesTab = [i, j];
            }           
        } 

        return indexesTab;
    }

    //Execute the code 
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
