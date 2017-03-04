using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bing.Maps;

namespace Stockport_Hackathon.classes
{
    public enum weatherList { SUNNY, CLEAR, PARTLY_CLOUDY, OVERCAST, MIST, PATCHY_RAIN_NEARBY, PATCHY_SNOW_NEARBY, PATCHY_SLEET_NEARBY, PATCHY_FREEZING_DRIZZLE_NEARBY, THUNDERLY_OUTBREAKS_IN_NEARBY, BLOWING_SNOW, BLIZZARD, FOG, FREEZING_FOG, PATCHY_LIGHT_DRIZZLE, LIGHT_DRIZZLE, FREEZING_DRIZZLE, HEAVY_FREEZING_DRIZZLE, PATCHY_LIGHT_RAIN, LIGHT_RAIN, MODERATE_RAIN_AT_TIMES}
    //public enum durationList { DAILY, WEEKLY, FORTNIGHTLY, MONTHLY, BI_MONTHLY, TERM_TIME, ANUAL, NOT_STATED, OTHER}
    public enum weekDay { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SUNDAY, SATURDAY}

    class Activity
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Location location;
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        //private DateTime dateAndTime;
        //public DateTime DateAndTime
        //{
        //    get { return dateAndTime; }
        //    set { dateAndTime = value; }
        //}

        private weatherList weather;
        public weatherList Weather
        {
            get { return weather; }
            set { weather = value; }
        }

        //If Activities have ranking based on popularity
        private int rank;
        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
    }
}
