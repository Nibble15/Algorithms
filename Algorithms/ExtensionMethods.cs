using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class ExtensionMethods {

        public static void Print(this string str) {
            Console.WriteLine(str);
        }

        /// <summary>
        /// prints an array of strings to the console eg: instance.PrintArray();
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(this string[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// prints an array of integers to the console eg: instance.PrintArray();
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(this int[] array) {
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// returns a string[] split at the parameter 'pos'(position) Default is null. 
        /// No parameter returns the string as the only element of the new array --
        /// eg: myString.Splits() --
        /// myString.Splits("") returns an array of characters --
        /// myString.Splits(" ") returns an array of words --
        /// myString.Splits("H") returns an array where each index holds all the values of the string after the given letter up to the next instance of that letter
        /// </summary>
        /// <param name="str"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static string[] Splits(this string str, string pos = null) {
            string[] splitString;
            string tempStr = "";
            if (pos == null) {
                splitString = new string[1];
                splitString[0] = str;
            }
            else {
                splitString = new string[StringIndexer(str, pos)];
                int count = 0;
                for (int i = 0; i < str.Length; i++) {
                    if (pos == "") {
                        splitString[i] = str[i].ToString();
                    }
                    else if (i < str.IndexOf(pos)) {
                        tempStr += str[i].ToString();
                    }
                    else if (str[i].ToString() == pos) {
                        splitString[count] = tempStr;
                        tempStr = "";
                        count++;
                    }
                    else if (i > str.IndexOf(pos) && i < str.Length) {
                        tempStr += str[i].ToString();
                        if (i == str.Length - 1) {
                            splitString[count] = tempStr;
                        }
                    }
                }
            }
            return splitString;
        }

        // private helper method for Splits()
        private static int StringIndexer(string str, string pos) {
            int count = 0;
            if (pos == "") {
                return str.Length;
            }
            for (int i = 0; i < str.Length; i++) {
                if (str[i].ToString() == pos || i == str.Length - 1) {
                    count++;
                }
            }
            return count;
        }
        

        /// <summary>
        /// Returns a string containing the value from the index supplied in the parameter 'num' up to the end of the string 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <returns>the substring</returns>
        public static string Slice(this string str, int num) {
            string slicedStr = String.Empty;
            for (int i = num; i < str.Length; i++) {
                slicedStr += str[i];
            }
            return slicedStr;
        }

        /// <summary>
        /// Returns a string between two given indexes. The string will contain the char at 'num' up to, but not including, 'num2'
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string Slice(this string str, int num, int num2) {
            string slicedStr = String.Empty;
            for (int i = num; i < num2; i++) {
                slicedStr += str[i];
            }
            return slicedStr;
        }


        /// <summary>
        /// Returns a string containing the number of words specified in wordCount
        /// NOTE: your string is the object and the parameter (thisString.Slice(thisString, 20))
        /// </summary>
        /// <param name="str"></param>
        /// <param name="thisString"></param>
        /// <param name="wordCount"></param>
        /// <returns></returns>
        public static string Slice(this string str, string thisString, int wordCount) {
            string slicedStr = String.Empty;
            int count = 0;
            for (int i = 0; i < thisString.Length; i++) {
                slicedStr += str[i];
                if (thisString[i].ToString() == " " || thisString[i] == thisString.Length) {
                    count++;
                    if (count == wordCount) {
                        break;
                    }
                }
            }
            return slicedStr.Trim();
        }
    
    }
}
    
