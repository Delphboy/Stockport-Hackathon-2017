using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bing.Maps;

namespace Stockport_Hackathon.classes
{
<<<<<<< HEAD
    public enum weatherList { SUNNY, CLEAR, PARTLY_CLOUDY, OVERCAST, MIST, PATCHY_RAIN_NEARBY, PATCHY_SNOW_NEARBY, PATCHY_SLEET_NEARBY, PATCHY_FREEZING_DRIZZLE_NEARBY, THUNDERLY_OUTBREAKS_IN_NEARBY, BLOWING_SNOW, BLIZZARD, FOG, FREEZING_FOG, PATCHY_LIGHT_DRIZZLE, LIGHT_DRIZZLE, FREEZING_DRIZZLE, HEAVY_FREEZING_DRIZZLE, PATCHY_LIGHT_RAIN, LIGHT_RAIN, MODERATE_RAIN_AT_TIMES}
    //public enum durationList { DAILY, WEEKLY, FORTNIGHTLY, MONTHLY, BI_MONTHLY, TERM_TIME, ANUAL, NOT_STATED, OTHER}
    public enum weekDay { MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SUNDAY, SATURDAY}
=======
    public enum weatherList { SUN, WIND, RAIN, STORM}
    public enum activityDay{ MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY}
    public enum activityType { PHYSICAL, HEALTH, CREATIVE, LEISURE}
>>>>>>> master

    class Activity
    {
        private activityType type;
        public activityType Type
        {
            get { return type; }
            set { type = value; }
        }

        private string region;
        public string Region
        {
            get { return region; }
            set { region = value; }
        }

<<<<<<< HEAD
        //private DateTime dateAndTime;
        //public DateTime DateAndTime
        //{
        //    get { return dateAndTime; }
        //    set { dateAndTime = value; }
        //}
=======
        private string venue;
        public string Venue
        {
            get { return venue; }
            set { venue = value; } 
        }
>>>>>>> master

        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string locality;
        public string Locality
        {
            get { return locality; }
            set { locality = value; }
        }
<<<<<<< HEAD
=======

        private string postcode;
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        private bool isIndoor;
        public bool IsIndoor
        {
            get { return isIndoor; }
            set { isIndoor = value; }
        }

        private bool isNDF;
        public bool IsNSF
        {
            get { return isNDF; }
            set { isNDF = value; }
        }

        private string details;
        public string Details
        {
            get { return details; }
            set { details = value;  }
        }

        private activityDay day;
        public activityDay Day
        {
            get { return day; }
            set { day = value;  }
        }

>>>>>>> master
    }
}
