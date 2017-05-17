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
            Console.WriteLine("Splits extension vs .NET Substring Method");
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

            Console.ReadLine();
        }
    }
}
