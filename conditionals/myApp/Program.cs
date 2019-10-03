using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            if ((a+b) > 10){
                Console.WriteLine("This is greater than 10");
            }
            else
            {
                Console.WriteLine("Sorry, but this is not greater than 10.");
            }
            
            try
            {
                // intentionally fail this
                throw new Exception("Test");
            }
            catch (System.Exception)
            {
                Console.WriteLine("You can't put a string in an int spot!");
                System.Environment.Exit(1);
                throw;
            }
        }
    }
}
