using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms.Exercises.Easy
{
    #region Comments
    /*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    You can return the answer in any order.



    Example 1:

    Input: nums = [2, 7, 11, 15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
    https://leetcode.com/problems/two-sum/
    */
    #endregion
    public class TwoSumExercise
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2 || nums == null)
            {
                throw new ArgumentException();
            }
            int[] result = null;
            var numbers = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (numbers.Contains(diff))
                {
                    result = new int[2];
                    result[0] = i;
                    result[1] = Array.IndexOf(nums, diff);
                    break;
                }
                numbers.Add(nums[i]);
            }

            return result;
        }
    }
}

