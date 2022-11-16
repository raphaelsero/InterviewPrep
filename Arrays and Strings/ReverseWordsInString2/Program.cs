/*
Given a character array s, reverse the order of the words.
A word is defined as a sequence of non-space characters. The words in s will be separated by a single space.
Your code must solve the problem in-place, i.e. without allocating extra space.

Input: s = ["t","h","e"," ","s","k","y"," ","i","s"," ","b","l","u","e"]
Output: ["b","l","u","e"," ","i","s"," ","s","k","y"," ","t","h","e"]

Input: s = ["a"]
Output: ["a"]

Constraints:

1 <= s.length <= 105
s[i] is an English letter (uppercase or lowercase), digit, or space ' '.
There is at least one word in s.
s does not contain leading or trailing spaces.
All the words in s are guaranteed to be separated by a single space.
 */

namespace ReverseWordsInString2 
{
    class Program
    { 
        public static void Main(string[] args)
        {
            //TODO: add test cases
        }
        public void ReverseWords(char[] s) //Time: O(N), Space: O(1)
        {
            int j = s.Length - 1;
            char tmp;
            int idxStart = 0;
            for (int i = 0; i < s.Length / 2; i++, j--)
            {
                tmp = s[i];
                s[i] = s[j];
                s[j] = tmp;
            }

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    if (i == s.Length - 1)
                    {
                        ReverseWord(s, idxStart, i);
                    }
                    else
                    {
                        ReverseWord(s, idxStart, i - 1);
                    }

                    idxStart = i + 1;
                    continue;
                }
            }
        }

        public void ReverseWord(char[] s, int idxStart, int idxEnd)
        {
            char tmp;
            for (int i = idxStart; i <= idxEnd; i++, idxEnd--)
            {
                tmp = s[i];
                s[i] = s[idxEnd];
                s[idxEnd] = tmp;
            }
        }
    }
}