using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    public static class ArrayMethods {
        
        /// <summary>
        /// takes a single integer n and returns an array of positive integers from 1 to n(codewars)
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
        /// Sort an array of odd values in ascending order - ignoring even numbers(codewars)
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

        /// <summary>
        /// sort an array once (codewars challenge)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int[] BubbleSortOnce(int[] input) {
            for (int i = 0; i < input.Length - 1; i++) {
                int currItem = input[i];
                if(currItem > input[i + 1]) {
                    input[i] = input[i + 1];
                    input[i + 1] = currItem;
                }
            }
            return input;
        }

        //CODEWARS challenge:
        //Suzuki is a monk who climbs a large staircase to the monastery as part of a ritual.Some days he climbs more stairs 
        //than others depending on the number of students he must train in the morning. He is curious how many stairs might 
        //be climbed over the next 20 years and has spent a year marking down his daily progress.
        //The sum of all the stairs logged in a year will be used for estimating the number he might climb in 20.
        //20_year_estimate = one_year_total * 20
        //You will receive the following data structure representing the stairs Suzuki logged in a year.You will have 
        //all data for the entire year so regardless of how it is logged the problem should be simple to solve.
        //stairs = [sunday, monday, tuesday, wednesday, thursday, friday, saturday]
        //Make sure your solution takes into account all of the nesting within the stairs array.
        //Each weekday in the stairs array is an array.
        //sunday = [6737, 7244, 5776, 9826, 7057, 9247, 5842, 5484, 6543, 5153, 6832, 8274, 7148, 6152, 5940, 8040, 9174, 7555, 
        //7682, 5252, 8793, 8837, 7320, 8478, 6063, 5751, 9716, 5085, 7315, 7859, 6628, 5425, 6331, 7097, 6249, 8381, 5936, 8496, 
        //6934, 8347, 7036, 6421, 6510, 5821, 8602, 5312, 7836, 8032, 9871, 5990, 6309, 7825]
        public static long StairsIn20(int[][] stairs) {
            long added = 0;
            for (var i = 0; i < stairs.Length; i++) {
                for (var j = 0; j < stairs[i].Length; j++) {
                    added += stairs[i][j];
                }
            }
            return added * 20;
        }

        //Codewars: return 0 if array is empty or null
        //else add all the numbers in the array except for the smallest and the largest numbers eg: { 6, 10, 1, 2, 8 } = 16
        public static int Sum(int[] numbers) {
            if (numbers == null || numbers.Length == 0) {
                return 0;
            }
            int total = 0;
            Array.Sort(numbers);
            for (var i = 1; i < numbers.Length - 1; i++) {
                total += numbers[i];
            }
            return total;
        }

        //Codewars challenge
        //return an array with count of positives and sum of negatives
        //if input is null return null array
        public static int[] CountPositivesSumNegatives(int[] input) {
            if (input == null || input.Length == 0) {
                return new int[0]; ; 
            }
            int[] output = new int[2];
            for (var i = 0; i < input.Length; i++) {
                if (input[i] < 0) {
                    output[1] += input[i];
                }
                if (input[i] > 0) {
                    output[0]++;
                }
            }
            return output;
        }
    }
}
