using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class ArrayMethods {
        
        /// <summary>
        /// takes a single integer n and returns an array of positive integers from 1 to n
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] PreFizz(int n) {
            int[] arr = new int[n];
            int x = 0;
            while (x < n) {
                try {
                    arr[x] = x + 1;
                    x++;
                }
                catch (System.IndexOutOfRangeException e) {
                    Console.WriteLine(e.Message);
                    throw new ArgumentOutOfRangeException("Index is out of range", e);
                }
            }
            return arr;
        }
            
    

        /// <summary>
        /// Sort an array of odd values in ascending order - ignoring even numbers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array) {
            for(int i = 0; i < array.Length;i++) {
                if(array[i] % 2 != 0) {
                    for(int j = i; j < array.Length; j++) {
                        if(array[j] % 2 != 0) {
                            int currItem = array[i];
                            if(array[i] > array[j]) {
                                array[i] = array[j];
                                array[j] = currItem;
                            }
                        }
                    }//end inner for
                }//end outer if
                else {
                    continue;
                }
            }
            return array;
        }

        
    }
}
