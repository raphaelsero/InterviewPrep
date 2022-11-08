/*
 A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
 it reads the same forward and backward. 
 Alphanumeric characters include letters and numbers.
 Given a string s, return true if it is a palindrome, or false otherwise.

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

Constraints:
1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
 */

using System.Text.RegularExpressions;

namespace ValidatePlaindrome
{
    class Program 
    { 
    
        public static void Main(string[] args)
        {
            //TODO: test cases
        }

        public bool IsPalindrome(string s) //Time: O(N/2), Space: O(1)
        {
            //"A man, a plan, a canal: Panama" -> "amanaplanacanalpanama"
            //"race a car" -> "raceacar"
            s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty).ToLower();
            int lastIdx = s.Length - 1;
            if (string.IsNullOrEmpty(s)) return true;
            for (int i = 0; i <= lastIdx; i++, lastIdx--)
            {
                if (s[i] != s[lastIdx]) return false;
            }
            return true;
        }
    }
}