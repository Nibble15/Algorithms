using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class StringMethods {

        public static string EvenOrOdd(int number) => (number % 2 == 0) ? "Even" : "Odd";

        public static string Reverse(string str) {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return String.Concat(charArr);
        }

        public static string ToAlternatingCase(this string s) {
            string swappedString = String.Empty;
            for(int i = 0; i < s.Length; i++) {
                if(char.IsUpper(s[i])) {
                    swappedString += char.ToLower(s[i]).ToString();
                }
                else {
                    swappedString += char.ToUpper(s[i]).ToString();
                }
            }
            return swappedString;
        }
    }
}
