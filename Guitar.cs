using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Guitar
    {
        //Properties
        public int DaysWithGuitar { get; set; }
        public string TypeOfGuitar { get; set; }
        public bool InTune { get; set; }
        public int StringWearAndTear { get; set; } 
        public int NeedForMaintenance { get; set; }
        public int SkillLevel { get; set; }


        //Constructors
        public Guitar()
        {
            DaysWithGuitar = 1;
            InTune = false;
            StringWearAndTear = 0; //If it reaches 100, a string will break and the user will not be able to play
            NeedForMaintenance = 0; //Let's say the user has to maintain the guitar every 30 days or so. Once this number reaches 30, the user will get a notification to get maintenance. The message will loop until the user takes the guitar in for repairs, aka GetMaintenance().
            SkillLevel = 0;
        }


        //Methods
        public int GetDay()
        {
            return DaysWithGuitar;
        }

        public void SetType(string typeOfGuitar)
        {
            TypeOfGuitar = typeOfGuitar.ToLower();
        }

        public string GetTypeOfGuitar()
        {
            return TypeOfGuitar;
        }

        public bool InTuneStatus()
        {
            return InTune;
        }

        public void DeTune()
        {
            InTune = false;
        }

        public void Tune()
        {
            InTune = true;
        }
        
        public int GetStringStatus()
        {
            return StringWearAndTear;
        }

        public void ChangeStrings()
        {
            StringWearAndTear = 0;
        }

        public int GetNeedForMaintenance()
        {
            return NeedForMaintenance;
        }

        public int GetSkillLevel()
        {
            return SkillLevel;
        }

        public void GuitarMaintenance()
        {
            NeedForMaintenance = 0;
            SkillLevel -= 5;
        }

        public void Practice()
        {
            SkillLevel += 3;
            StringWearAndTear += 10;
            InTune = false;
        }

        public void Play()
        {
            SkillLevel += 2;
            StringWearAndTear += 5;
            InTune = false;
        }

        public void Time()
        {
            SkillLevel -= 1;
            StringWearAndTear += 1;
            NeedForMaintenance += 1;
            DaysWithGuitar += 1;
        }

    }
}
