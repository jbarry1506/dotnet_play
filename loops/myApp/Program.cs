using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int total = 0;
            Console.WriteLine("You have 3 tries to get numbers that add up to 10.  Good luck.");
            int counter = 0;
            while ((counter < 3) && (total != 10)){
                if (counter == 0){
                    Console.WriteLine("Please enter a number between 0 and 9 for value 'a'.");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter a number between 0 and 9 for value 'b'.");
                    int b = Convert.ToInt32(Console.ReadLine());
                    total = a+b;
                    Console.Clear();
                }

                if (total == 10){
                    Console.WriteLine("Congratulations!  You win!");
                }
                else if (total < 10){
                    Console.WriteLine("It looks like you need to add something to make the total to equal 10.");
                    Console.WriteLine("What number would you like to add?");
                    int c = Convert.ToInt32(Console.ReadLine());
                    total+=c;
                    Console.Clear();
                    if (total == 10){
                        Console.WriteLine("Congratulations!  You win!");
                    }
                }
                else if (total > 10){
                    Console.WriteLine("It looks like you need to subtract something to make the total to equal 10.");
                    Console.WriteLine("What number would you like to subtract?");
                    int c = Convert.ToInt32(Console.ReadLine());
                    total-=c;
                    Console.Clear();
                    if (total == 10){
                        Console.WriteLine("Congratulations!  You win!");
                    }
                }
                counter++;
                if ((counter == 3) && (total != 10)){
                    Console.Clear();
                    Console.WriteLine("Whomp Whomp.  Sorry.  Better luck next time!");
                }
            }
        }
    }
}
