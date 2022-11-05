/*
 Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

Input: digits = "23"
Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

Input: digits = ""
Output: []

Input: digits = "2"
Output: ["a","b","c"]
 
Constraints:

0 <= digits.length <= 4
digits[i] is a digit in the range ['2', '9'].
 
 */


using System.Text;

namespace LetterCombinationsOfPhoneNumber
{
    class Program
    {
        List<string> combinations = new List<string>();
        Dictionary<char, string> letters = new Dictionary<char, string>() {
            { '2', "abc" }, {'3', "def" }, {'4', "ghi" }, {'5', "jkl" }, {'6', "mno" }, {'7', "prqs" }, {'8', "tuv" }, {'9', "wxyz" }
        };
        string phoneDigits;

        static void Main(string[] args)
        {
            //TODO: implement test cases
        }

        // Time: O(V^N * N), where N is digits.Length and V is max value length. Space: O(N) where N is digits.Length
        public IList<string> LetterCombinations(string digits) 
        {
            if (digits.Length == 0) return combinations; // If the input is empty, immediately return an empty answer array

            // Initiate backtracking with an empty path and starting index of 0
            phoneDigits = digits;
            Backtrack(0, new StringBuilder());
            return combinations;
        }

        public void Backtrack(int idx, StringBuilder path) 
        {
            // If the path is the same length as digits, we have a complete combination
            if (path.Length == phoneDigits.Length)
            {
                combinations.Add(path.ToString());
                return;
            }

            // Get the letters that the current digit maps to, and loop through them
            if (letters.TryGetValue(phoneDigits[idx], out string? possibleLetters))
            {
                foreach (char l in possibleLetters)
                {
                    path.Append(l);                 // Add the letter to our current path
                    Backtrack(idx + 1, path);       // Move on to the next digit
                    path.Remove(path.Length - 1, 1);// Backtrack by removing the letter before moving onto the next
                }
            }
        }
    }
}
