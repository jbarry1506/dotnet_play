using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int d20 = 0;
            int d6 = 0;
            int d4 = 0;
            int initiative = 0;

            int hitPoints = 10;
            int goblinHitPoints = 10;

            Console.WriteLine("A goblin is approaching you with an evil grin on his greasy face,\n"
                + "running a finger along a dull short sword");

            do{   
                initiative = rnd.Next(1,3);
                if (initiative == 1){
                    Console.WriteLine("You are ready first!");
                    Console.WriteLine("Would you like to attack or defend?");
                    Console.WriteLine("\t1:  Attack");
                    Console.WriteLine("\t2:  Defend");
                    int action = Convert.ToInt32(Console.ReadLine());
                    if (action == 1){
                        d20 = rnd.Next(1,21);
                        if (d20 > 10) {
                            Console.WriteLine("You strike the goblin!");
                            d6 = rnd.Next(1,7);
                            goblinHitPoints-= d6;
                            Console.WriteLine("You did {0} damage to the goblin!", d6);
                        }
                        else {
                            Console.WriteLine("Oh no!  You missed!");
                        }
                    }
                    else {
                        Console.WriteLine("The goblin takes the opportunity to attack!");
                        decimal defend = (rnd.Next(1,5))/2;
                        int dmg = Convert.ToInt32(Math.Round(defend));
                        Console.WriteLine("You took {0} damage!",dmg);
                    }
                }
                else{
                    Console.WriteLine("The goblin leaps forward, surprising you!");
                    d20 = rnd.Next(1,21);
                    if (d20 > 10) {
                        Console.WriteLine("The goblin strikes you!");
                        d4 = rnd.Next(1,5);
                        Console.WriteLine("You took {0} damage!",d4);
                    }
                    else{
                        Console.WriteLine("The goblin misses!");
                    }
                }
            } while ((hitPoints > 0) && (goblinHitPoints > 0));
        }
    }
}
