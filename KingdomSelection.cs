using System;
using System.Collections.Generic;
using System.Text;

namespace greektrust_TameofThrones
{

    //Coded by Rubseena N U
    public class KingdomSelection
    {
        //Class for describing Kingdom and Emblem as enumorator
        public enum kingdomStuff
        {
            SPACE, LAND, WATER, ICE, AIR, FIRE
        }
        public string Animal(string stkingdom)
        {

            kingdomStuff kg = (kingdomStuff)Enum.Parse(typeof(kingdomStuff), stkingdom);

            switch (kg)
            {
                case kingdomStuff.SPACE:
                    return "GORILLA";
                case kingdomStuff.LAND:
                    return "PANDA";
                case kingdomStuff.WATER:
                    return "OCTOPUS";
                case kingdomStuff.ICE:
                    return "MAMMOTH";
                case kingdomStuff.AIR:
                    return "OWL";
                case kingdomStuff.FIRE:
                    return "DRAGON";
                default:
                    return null;
            }

        }
    }
}
