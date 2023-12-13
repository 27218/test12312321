/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class HelloWorld {
    public static int[] TwoSum(int[] nums, int target) {
        int[] output = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                if(target == (nums[i] + nums[j]))
                {
                    output[0] = i;
                    output[1] = j;
                    break;
                } 
            }
        }
        return output;    
    }

    static void Main() {
        int[] nums = {2,7,11,15};
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.Write($"[{result[0]}, {result[1]}]");
    }
}