/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 
 */

using System;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args) 
        {
            int[] array1 = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] resultOfBruteForce = TwoSumBruteForce(array1, target);
            int[] resultOfOptimized = TwoSumOptimized(array1, target);

            Console.WriteLine("[" + string.Join(",", resultOfBruteForce) + "]");
            Console.WriteLine("[" + string.Join(",", resultOfOptimized) + "]");

        }

        public static int[] TwoSumOptimized(int[] nums, int target) // Using a Dictionary: Time Complexity: O(n), Space complexity: O(n)
        {
            int arrLen = nums.Length;
            Dictionary<int, int> resultDictionary = new();

            //Validations
            if (nums == null || arrLen < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < arrLen; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i };
                }
                resultDictionary[firstNumber] = i;
            }

            return Array.Empty<int>(); 
        }

        public static int[] TwoSumBruteForce(int[] nums, int target) //Brute force: Time Complexity: O(n^2), Space complexity: O(1)
        {
            int arrLen = nums.Length;

            //Validation
            if (nums == null || arrLen < 2)
            {
                return Array.Empty<int>();
            }

            //Logic
            for (int i = 0; i < arrLen; i++)
            {
                for (int j = i + 1; j < arrLen; j++)
                {
                    if (nums[j] + nums[i] == target) return new int[] { i, j };
                }
            }

            return Array.Empty<int>();
        }
    }
}