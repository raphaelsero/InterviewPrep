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
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return combinations;

            phoneDigits = digits;
        }

        public void Backtrack(int idx, StringBuilder path)
        {
            if (path.Length == phoneDigits.Length)
            {
                combinations.Add(path.ToString());
                return;
            }

        }
    }
}
