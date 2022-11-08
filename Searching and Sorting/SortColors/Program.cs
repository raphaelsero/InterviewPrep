/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
You must solve this problem without using the library's sort function.

Example 1:
Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Example 2:
Input: nums = [2,0,1]
Output: [0,1,2]
 
Constraints:
n == nums.length
1 <= n <= 300
nums[i] is either 0, 1, or 2.
 
Follow up: Could you come up with a one-pass algorithm using only constant extra space? 
 */

using System.Reflection;
using System.Xml.Linq;
using System;

namespace SortColors
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO: Implement test cases
        }

        //Initialise the rightmost boundary of zeros : p0 = 0. During the algorithm execution nums[idx < p0] = 0.
        //Initialise the leftmost boundary of twos : p2 = n - 1. During the algorithm execution nums[idx > p2] = 2.
        //Initialise the index of current element to consider : curr = 0.

        //While curr <= p2 :
        //If nums[curr] = 0 : swap currth and p0th elements and move both pointers to the right.
        //If nums[curr] = 2 : swap currth and p2th elements.Move pointer p2 to the left.
        //If nums[curr] = 1 : move pointer curr to the right.
        public void SortColors(int[] nums) //Time: O(N), Space: O(1)
        {
            int zerosIdx = 0;
            int currIdx = 0;
            int twosIdx = nums.Length - 1;

            int tmp;

            while (currIdx <= twosIdx)
            {
                if (nums[currIdx] == 0)
                {
                    tmp = nums[zerosIdx];
                    nums[zerosIdx++] = nums[currIdx];
                    nums[currIdx++] = tmp;
                }
                else if (nums[currIdx] == 2)
                {
                    tmp = nums[currIdx];
                    nums[currIdx] = nums[twosIdx];
                    nums[twosIdx--] = tmp;
                }
                else
                {
                    currIdx++;
                }
            }
        }

    }
}