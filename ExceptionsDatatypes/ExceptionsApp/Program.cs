using System;
using System.IO;
using System.Collections.Generic;

namespace ExceptionsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int anInt = 3; // explicitly typed
            //var vInt = 3; // impiecitly typed
            //var v2Int = vInt; //implicitly typed

            //var name = "Cathy";
            //var isClean = true;
            //var letter = 'P';
            //var uLongNum = 52uL;

            //var prices = new List<decimal>();

            //short n1 = -65;
            //ushort n2 = 65;
            //int n3 = -100_00;
            //uint n4 = 100_000;
            //uint n5 = 4_000_000_000;
            //long n6 = -5_000_000_000;
            //ulong n7 = 5_000_000_000;
            //var max = Int32.MaxValue;

            //float sum = 0;
            //for (int i = 0; i < 100_000; i++)
            //{
            //    sum += 2 / 5.0f;
            //}
            //Console.WriteLine("2/5 added 100,000 times " + sum);
            //Console.WriteLine("2/5 multiplied 100,000 times " + 2/5.0f * 100_000);


            //string text;
            //string fileName = "";

            //try
            //{
            //    Console.WriteLine("Anil's mark is 82: " + Grade(21));
            //    Console.WriteLine("Cathy's mark is -23: " + Grade(-23));
            //    Console.WriteLine("Jeff's mark is 69: " + Grade(69));
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Invalid data, please try again");
            //    Console.WriteLine(e.Message);
            //}
            

            //try
            //{
            //    text = File.ReadAllText(fileName);
            //    Console.WriteLine(text);
            //}
            //catch (FileNotFoundException e)
            //{
            //    Console.WriteLine("Sorry I can't find: " + fileName);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("You gave me an empty file name - " + e.Message); //e.message returns the name of the exception
            //}
            //finally //finally will always run even if there is a catch
            //{
            //    Console.WriteLine("We made it here!");
            //}
           // var text = File.ReadAllText("HelloWorld.txt"); //throws exception as file doesnt exist (not a programming error)
        }
        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark: " + mark + ", Allowed range of 0-100");
            }
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}



// exception is an error occuring during runtime
