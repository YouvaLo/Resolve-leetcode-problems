public class Program
{
    public static int SearchInsert(int[] nums, int target)
    {
        if (!nums.Contains(target))
        {
            nums = nums.Append(target).ToArray();
            Array.Sort(nums);
            return Array.IndexOf(nums, target);
        }

        //Or : nums.Order().ToArray();
        //nums = [2 1 4 3] --> Array.Sort(nums) --> nums = [1 2 3 4]
        Array.Sort(nums); 
        var index = Array.IndexOf(nums, target);
        
        return index;
    }

    public static void Main()
    {
        int[] nums = [1, 4, 3, 5];
        int target = 2; 
        Console.WriteLine($"Index of {target} is {SearchInsert(nums, target)}");
    }
}