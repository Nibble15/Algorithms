using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class IntegerMethods {

        /// <summary>
        /// returns if an integer is odd or even given its parameter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string EvenOrOdd(int number) => (number % 2 == 0) ? "Even" : "Odd";
    }
}
