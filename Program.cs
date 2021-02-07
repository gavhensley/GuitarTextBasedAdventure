using System;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guitar Player Simulator!" );
            Console.WriteLine("\nThis will give you some insight into the daily life of a guitar player.");
            Console.WriteLine("We won't go too in depth, but this should give you an idea of what happens in the daily life of a guitar player from getting their first guitar.");

            bool simulation = true;

            Guitar myGuitar = new Guitar();

            Console.WriteLine("\nWhat kind of guitar do you want? Steel string acoustic? Electric? Classical? Flamenco?");
            myGuitar.SetType((Console.ReadLine()));
            Console.Clear();
            
            while (simulation is true)
            Console.WriteLine($"It's Day: {myGuitar.GetDay()} with your {(myGuitar.GetTypeOfGuitar())} guitar! Let's check out the guitar and how you are doing!");
            //stats 
            Console.WriteLine($"\nGuitar is in Tune?: {myGuitar.InTuneStatus()}");
            Console.WriteLine($"String wear and tear: {myGuitar.GetStringStatus()}/100");
            Console.WriteLine($"Need for maintenance: {myGuitar.GetNeedForMaintenance()}/30");
            Console.WriteLine($"Your skill level: {myGuitar.GetSkillLevel()}/Only you decide the limit");

            Console.WriteLine("\n1. Tune guitar");
            Console.WriteLine("2. Practice");
            Console.WriteLine("3. Change Strings");
            Console.WriteLine("4. Take the guitar in for maintenance");
            Console.WriteLine("5. Play a concert (recommended Skill is 25)");
            Console.WriteLine("6. End simulation");
            

        }
    }
}
