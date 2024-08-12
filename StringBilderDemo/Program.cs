using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Stopwatch sw1 = new Stopwatch();
            
            //string s1 = "Sai";
            //sw1.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    s1 = s1 + i; // everytime we concatinate to the string, there will be 100000 new strings formed in the end as there is a new string every time we concatinate 
            //}
            //sw1.Stop();
            ////Console.WriteLine("Complited");

            //Stopwatch sw2 = new Stopwatch();

            //StringBuilder sb = new StringBuilder("Hello");
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i); // everytime we append to the stringbuilder, the string will undergo 100000 times changes 
            //}

            //Console.WriteLine("Time taken by string is : " + sw1.ElapsedMilliseconds);
            //Console.WriteLine("Time taken by stringbuilder is : " + sw2.ElapsedMilliseconds);

            //Console.WriteLine("--------------------");

            StringBuilder sb2 = new StringBuilder("Hello World!");

            Console.WriteLine(sb2.GetType());

            //sb2.Append("Indu Sree");
            //sb2.AppendLine(" Gandikota");  // what ever we append after this will print on the next line
            //sb2.Append(" Venkata");  // Prints in the same line as the first if the appendline is not used

            //sb2.AppendFormat("{0:C}",25);

            //sb2.Insert(12, "C#");

            //sb2.Replace("l", "o"); // will replace the old char "l" with new char "o"

            //Console.WriteLine(sb2);

            // To convert stringbuilder into string we need to use "ToString()"

            string str = sb2.ToString();

            Console.WriteLine(str);
            Console.WriteLine(str.GetType());
        }
    }
}