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


            Console.ReadLine();
        }
    }
}
