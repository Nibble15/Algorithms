using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class StringMethods {

        /// <summary>
        /// reverse a string eg: Hello, World == dlroW ,olleH
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str) {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return String.Concat(charArr);
        }

        /// <summary>
        /// Upper to lower and lower to upper (codewars)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
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
