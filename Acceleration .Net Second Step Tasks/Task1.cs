using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceleration_.Net_Second_Step_Tasks
{
    public static class Task1
    {
        public static bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Empty string can't be palindrome...");
                return false;
            }

            text = text.Replace(" ", "").ToLower();
            int length = text.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (text[i] != text[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
