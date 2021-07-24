using RotatorMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RotatorMVC.Helpers
{
    public class PalindromeHelper
    {
        public static Palindrome CheckPalindrome(Palindrome palindrome)
        {
            if(string.IsNullOrEmpty(palindrome.InputWord))
            {
                palindrome.InputWord = "Rotator";
            }

            string inputWord = palindrome.InputWord;
            string reversedWord = string.Empty;

            reversedWord = new string(palindrome.InputWord.Reverse().ToArray());
            palindrome.ReversedWord = reversedWord;

            reversedWord = Regex.Replace(reversedWord.ToLower(), "\\W+", "");
            inputWord = Regex.Replace(inputWord.ToLower(), "\\W+", "");

            if (reversedWord == inputWord)
            {
                palindrome.IsPalindrome = true;
                palindrome.Message = $"Success {palindrome.InputWord} is a Palindrome!";
            }
            else
            {
                palindrome.IsPalindrome = false;
                palindrome.Message = $"Sorry {palindrome.InputWord} is not a Palindrome!";
            }

            return palindrome;
        }
    }
}
