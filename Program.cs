using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guitar Player Simulator!" );
            Console.WriteLine("\nThis will give you some insight into the routine of a guitar player.");
            Console.WriteLine("We won't go too in depth, but this should give you an idea of what happens in the daily life of a guitar player from getting their first guitar.");

            bool simulation = true;

            Guitar myGuitar = new Guitar();

            Console.WriteLine("\nWhat kind of guitar do you want? Steel string acoustic? Electric? Classical? Flamenco?");
            myGuitar.SetType((Console.ReadLine()));
            Console.Clear();

            while (simulation is true)
            {
                Console.WriteLine($"It's Day: {myGuitar.GetDay()} with your {(myGuitar.GetTypeOfGuitar())} guitar! Let's check out the guitar and how you are doing!");
                //stats 
                Console.WriteLine($"\nGuitar is in Tune?: {myGuitar.InTuneStatus()}");

                if (myGuitar.StringWearAndTear >= 100)
                {
                    Console.WriteLine($"String wear and tear: {myGuitar.GetStringStatus()}/100\nYour strings are muffled and dirty, and one of them broke! Time to change your strings!");
                }
                else
                {
                    Console.WriteLine($"String wear and tear: {myGuitar.GetStringStatus()}/100");
                }

                if (myGuitar.NeedForMaintenance >= 30)
                {
                    Console.WriteLine($"Need for maintenance: {myGuitar.GetNeedForMaintenance()}/30\n!!! Your guitar doesn't feel quite right in your hands. It has been about a month. \nLuckily you know a luthier who can make all the necessary fixes an adjustments. Choose option 4 to give them a visit!");
                }
                else
                {
                    Console.WriteLine($"Need for maintenance: {myGuitar.GetNeedForMaintenance()}/30");
                }
                Console.WriteLine($"Your skill level: {myGuitar.GetSkillLevel()}/??");

                Console.WriteLine("\n1. Tune guitar");
                Console.WriteLine("2. Practice");
                Console.WriteLine("3. Change Strings");
                Console.WriteLine("4. Take the guitar in for maintenance");
                Console.WriteLine("5. Take the day off");
                if (myGuitar.InTune is false || myGuitar.StringWearAndTear > 100 || myGuitar.NeedForMaintenance > 30 || myGuitar.SkillLevel < 10) { Console.Write(""); }
                else
                {
                    Console.WriteLine("6. Play a concert!");
                }
                Console.WriteLine("q: End simulation");

                var playerChoice = Console.ReadLine();
                switch (playerChoice)
                {
                    case "1":
                        myGuitar.Tune();
                        Console.WriteLine("You tuned up your guitar! You're ready to play!");
                        break;
                    case "2":
                        if (myGuitar.InTune is false)
                        {
                            Console.WriteLine("You did your practice routine, but it didn't sound quite right. Make sure your guitar is in tune next time.");
                        }
                        else
                        {
                        Console.WriteLine("You practiced some exercises and a couple of songs you want to get better with. \nYou're getting better with every hour you put in! Great work!");
                        }
                        myGuitar.Practice();
                        myGuitar.Time();
                        break;
                    case "3":
                        myGuitar.ChangeStrings();
                        Console.WriteLine("You put on some new strings. That first chord you play sounds so crisp and clean!");
                        break;
                    case "4":
                        myGuitar.GuitarMaintenance();
                        Console.WriteLine("You take the guitar to a luthier. They are very busy and you don't have your guitar for a couple days. \n Make sure to practice once you get it back!");
                        break;
                    case "5":
                        myGuitar.Time();
                        Console.WriteLine("You took the day off. We all need a break once in a while right? \nJust be sure to keep at it so that you don't lose what progress you made!");
                        break;
                    case "6":
                        myGuitar.PlayConcert();
                        myGuitar.Time();
                        break;
                    case "q":
                        simulation = false;
                        break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
