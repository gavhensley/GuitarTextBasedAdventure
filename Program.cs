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

                Console.Write("Your choice: ");
                var playerChoice =  Console.ReadLine();
                switch (playerChoice)
                {
                    case "1":
                        myGuitar.Tune();
                        Console.WriteLine("\nYou tuned up your guitar! You're ready to play!");
                        break;
                    case "2":
                        if (myGuitar.InTune is false)
                        {
                            Console.WriteLine("\nYou did your practice routine, but it didn't sound quite right. Make sure your guitar is in tune next time.");
                        }
                        else
                        {
                        Console.WriteLine("\nYou practiced some exercises and a couple of songs you want to get better with. \nYou're getting better with every hour you put in! Great work!");
                        }
                        myGuitar.Practice();
                        myGuitar.Time();
                        break;
                    case "3":
                        myGuitar.ChangeStrings();
                        Console.WriteLine("\nYou put on some new strings. That first chord you play sounds so crisp and clean!");
                        break;
                    case "4":
                        myGuitar.GuitarMaintenance();
                        Console.WriteLine("\nYou take the guitar to a luthier. They are very busy and you don't have your guitar for a couple days. \n Make sure to practice once you get it back!");
                        break;
                    case "5":
                        myGuitar.Time();
                        Console.WriteLine("\nYou took the day off. We all need a break once in a while right? \nJust be sure to keep at it so that you don't lose what progress you made!");
                        break;
                    case "6":
                        if (myGuitar.SkillLevel >= 10 && myGuitar.SkillLevel < 20)
                        {
                            Console.WriteLine("\nYou played a song for a couple of friends! They were surprised to see how good you are so soon after starting.");
                        }
                        else if (myGuitar.SkillLevel >= 20 && myGuitar.SkillLevel < 30)
                        {
                            Console.WriteLine("\nYou played at a family gathering and was congratulated for your hard work.");
                        }
                        else if (myGuitar.SkillLevel >= 30 && myGuitar.SkillLevel < 40)
                        {
                            Console.WriteLine("\nYou played an open mic night at a coffee shop. The reception was mixed with some clapping and others not paying much attention.\nThis happens. Keep it up.");
                        }
                        else if (myGuitar.SkillLevel >= 40 && myGuitar.SkillLevel <50)
                        {
                            Console.WriteLine("\nYou play an open mic at a coffee shop. This time everyone goes quiet.\nYou have everyone's attention. Once you are done with your song they all applaud. Great work!");
                        }
                        else
                        {
                            Console.WriteLine("You got a gig! Since you have been practicing hard and making sure your guitar is in good shape, you wow the crowd with your music. \n\nNow I'm just a computer program, so I don't know how far" +
                                " you'll go, but pick up an instrument and play! It's a great diversion and teaches a lot about delayed gratification, but once you get it right and share musice, there's few better feelings in " +
                                "the world. Good luck! You're going to do great.");

                        }
                        myGuitar.PlayConcert();
                        myGuitar.Time();
                        break;
                    case "q":
                        simulation = false;
                        break;
                    case "f":
                        Console.WriteLine("\nFree Bird!");
                        break;
                    default: 
                            Console.WriteLine("\nNot sure what you are going for there, but try one of the options in the menu by typing the number and hit enter. \nOr hit f and enter for the bain of all guitarists.");
                            break;
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
