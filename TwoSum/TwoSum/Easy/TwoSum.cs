using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class TwoSum
    {
        public TwoSum()
        {
            var nums = new int[] { 3, 3 };
            const int target = 6;
            var result = GetTwoSum(nums, target);
            Console.WriteLine("Outputs are : {0} and {1}", result[0], result[1]);
        }
        public int[] GetTwoSum(int[] nums, int target)
        {
            if (nums.Length >= 2 && nums.Length <= 10000)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    var diff = target - nums[i];
                    var index = Array.FindIndex(nums, x => x == diff);
                    if (index > -1 && index != i)
                        return new[] { i, index };
                }
            }
            throw new InvalidOperationException("Invalid Inputs");
        }
    }
}
