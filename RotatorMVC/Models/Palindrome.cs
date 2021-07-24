using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotatorMVC.Models
{
    public class Palindrome
    {
        public string InputWord { get; set; }
        public string ReversedWord { get; set; }
        public bool IsPalindrome { get; set; }
        public string Message { get; set; }
    }
}
