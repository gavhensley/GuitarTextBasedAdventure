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
            StringWearAndTear = 0; 
            NeedForMaintenance = 0; 
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
            DaysWithGuitar += 4;
        }

        public void Practice()
        {
            SkillLevel += 3;
            StringWearAndTear += 10;
            InTune = false;
        }

        public void PlayConcert()
        {
            SkillLevel += 2;
            StringWearAndTear += 5;
            InTune = false;
        }

        public void Time()
        {
            if (SkillLevel <= 0)
            {
                SkillLevel = 0;
            }
            else
            {
            SkillLevel -= 1;
            }
            StringWearAndTear += 1;
            NeedForMaintenance += 1;
            DaysWithGuitar += 1;
        }

    }
}
