using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms {
    class Program {
        static void Main(string[] args) {
            

            Console.WriteLine();
            string myText = "Hello, World! How the heck are you today!?";
            int[] myArray = new int[] {
                5, 6, 3, 2, 1, 8, 12, 13, 7
            };

            int[] actual = new int[] {
                9, 7, 5, 3, 1, 2, 4, 6, 8
            };

            var expected = new int[] {
                7, 5, 3, 1, 2, 4, 6, 8, 9
            };
            string myText2 = "HeLlo, wORLD! hoW Are yOU?";
            Console.WriteLine("split sentence");//split doesn't create a single complete sentence array like splits does. 
            myText.Split().PrintArray();
            Console.WriteLine("splits sentence-----");
            myText.Splits().PrintArray();
            Console.WriteLine("split words");
            myText.Split(' ').PrintArray();
            Console.WriteLine("splits words------");
            myText.Splits(" ").PrintArray();
            Console.WriteLine("splits characters-----");
            myText.Splits("").PrintArray();
            Console.WriteLine("split at letters");
            myText.Split('H').PrintArray();
            Console.WriteLine("splits at letters-----");
            myText.Splits("H").PrintArray();

            Console.WriteLine();

            Console.WriteLine("Slice extension vs .NET Substring Method");
            Console.WriteLine("-------sliced string-------");
            Console.WriteLine(myText.Slice(1));
            Console.WriteLine("-------substring string-------");
            Console.WriteLine(myText.Substring(1));
            Console.WriteLine("-------overloaded sliced string-------");
            Console.WriteLine(myText.Slice(0, 2));
            Console.WriteLine("-------overloaded substring string-------");
            Console.WriteLine(myText.Substring(0, 2));
            Console.WriteLine("-------overloaded sliced string word count-------");
            Console.WriteLine(myText.Slice(myText, 1));
            Console.WriteLine(myText.Slice(myText, 3));
            Console.WriteLine(myText.Slice(myText, 5));
            Console.WriteLine(myText.Slice(myText, 7));

            Console.WriteLine();

            Console.WriteLine("PreFizz method--------");
            ArrayMethods.PreFizz(0).PrintArray();
            ArrayMethods.PreFizz(1).PrintArray();
            ArrayMethods.PreFizz(2).PrintArray();
            ArrayMethods.PreFizz(5).PrintArray();
            ArrayMethods.PreFizz(10).PrintArray();
            ArrayMethods.PreFizz(20).PrintArray();

            Console.WriteLine();

            Console.WriteLine("Reverse String Method--------");
            StringMethods.Reverse(myText).Print();

            Console.WriteLine();

            Console.WriteLine("Sort an array's odd values---------");
            ArrayMethods.SortArray(myArray).PrintArray();

            Console.WriteLine();

            Console.WriteLine("Swap the case of a string---------");
            Console.WriteLine("original version");
            Console.WriteLine(myText2);
            Console.WriteLine("Updated version");
            myText2.ToAlternatingCase().Print();

            Console.WriteLine();

            Console.WriteLine("Bubble Sort Once---------");
            Console.WriteLine("original");
            actual.PrintArray();
            Console.WriteLine("expected");
            expected.PrintArray();
            Console.WriteLine("sorted");
            ArrayMethods.BubbleSortOnce(actual).PrintArray();

            Console.WriteLine();

            Console.WriteLine("evens or odds-------");
            IntegerMethods.EvenOrOdd(5).Print();
            IntegerMethods.EvenOrOdd(6).Print();
            IntegerMethods.EvenOrOdd(1000).Print();
            IntegerMethods.EvenOrOdd(501).Print();

            Console.WriteLine();

            Console.WriteLine("Guessing game");
            //guesser class is created below 
            //codewars challenge
            Guesser guesser = new Guesser(10, 2);
            Console.WriteLine(guesser.Guess(5));
            Console.WriteLine(guesser.Guess(10));

            Guesser guesser2 = new Guesser(10, 2);
            Console.WriteLine(guesser2.Guess(5));
            Console.WriteLine(guesser2.Guess(6));
            //Console.WriteLine(guesser2.Guess(10)); //uncomment to throw an error

            Console.WriteLine();

            Console.WriteLine("Codewars - invert values challenge");
            int[] InvertValues(int[] input) {
                int[] output = new int[input.Length];
                for (var i = 0; i < input.Length; i++) {
                    output[i] = (~input[i]) + 1;
                }
                return output;
            }

            int[] InvertValues2(int[] input) {
                for (var i = 0; i < input.Length; i++) {
                    input[i] = (~input[i]) + 1;
                }
                return input;
            }

            int[] invertedValues = InvertValues(myArray);
            int[] invertedValues2 = InvertValues2(myArray);

            Console.Write("The value of the items of myArray are: ");
            foreach (var item in myArray) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.Write("The inverted values of the items of myArray are: ");
            foreach (var item in invertedValues) {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("The inverted values from of the items of myArray using InvertedValues2 are: ");
            foreach (var item in invertedValues2) {
                Console.Write(item + " ");
            }

            Console.WriteLine();
           
            //Treehouse challenge
            List<int> GetPowersOf2(int number) {
                List<int> powersOf2 = new List<int>(number + 1);
                for (var i = 0; i < number + 1; i++) {
                    powersOf2.Add((int)Math.Pow(2, i));
                }
                return powersOf2;
            }

            var list = GetPowersOf2(4);
            foreach (var item in list) {
                Console.WriteLine(item);
            }
            



            Console.ReadLine();
        }
    }

    //codewars challenge
    public class Guesser {
        private int number;
        private int lives;
        private int guesses = 0;

        public Guesser(int number, int lives) {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n) {
            if (guesses > lives) {
                throw new System.Exception();
            }

            if (n != this.number) {
                this.lives--;
                guesses++;
            }

            if (n == this.number) {
                return true;
            }
            return false;
        }
    }
}
