using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class Dictionaries {

        //CODEWARS: Alphabet War
        public static Dictionary<char, int> leftSide = new Dictionary<char, int> {
     { 'w', 4 },
     { 'p', 3 },
     { 'b', 2 },
     { 's', 1 }
   };
        public static Dictionary<char, int> rightSide = new Dictionary<char, int> {
     { 'm', 4 },
     { 'q', 3 },
     { 'd', 2 },
     { 'z', 1 }
    };
        public static string AlphabetWar(string fight) {
            int leftTotal = 0;
            int rightTotal = 0;
            foreach (var character in fight) {
                if (leftSide.ContainsKey(character)) {
                    leftTotal += leftSide[character];
                }
                if (rightSide.ContainsKey(character)) {
                    rightTotal += rightSide[character];
                }
            }
            if (leftTotal > rightTotal) {
                return "Left side wins!";
            }
            else if (rightTotal > leftTotal) {
                return "Right side wins!";
            }
            return "Let's fight again!";
        }
    }
}
