using System;
using System.IO;

namespace ExceptionsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text;
            string fileName = "";

            try
            {
                Console.WriteLine("Anil's mark is 82: " + Grade(21));
                Console.WriteLine("Cathy's mark is -23: " + Grade(-23));
                Console.WriteLine("Jeff's mark is 69: " + Grade(69));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid data, please try again");
                Console.WriteLine(e.Message);
            }
            

            try
            {
                text = File.ReadAllText(fileName);
                Console.WriteLine(text);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sorry I can't find: " + fileName);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("You gave me an empty file name - " + e.Message); //e.message returns the name of the exception
            }
            finally //finally will always run even if there is a catch
            {
                Console.WriteLine("We made it here!");
            }
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
