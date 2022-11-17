/*
    Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    Note that you must do this in-place without making a copy of the array.
 */

using System.Linq;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program 
    { 
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 0, 0, 0, 2, 3, 0 };
            Solution(arr);
        }

        public static void Solution(int[] nums) 
        {
            //[1,2,3,4,0,0,3,0,5,0]
            //[1,2,3,4,3,0,0,0,5,0]
            //[1,2,3,4,3,5,0,0,0,0]

            //loop though int array
            //if I find nums[i] == 0
            //look ahead until i find a non zero 
            //then swap nums[i] with nums[j]
            //continue in for loop

            int tmp;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) 
                { 
                    for(int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            tmp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = tmp;
                            break;
                        }
                        else 
                        {
                            if (j == nums.Length - 1) return;
                        }
                    }
                }
            }    
        }
    }
}