using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bing.Maps;

namespace Stockport_Hackathon.classes
{
    public enum weatherList { SUN, WIND, RAIN, STORM}
    public enum durationList { DAILY, WEEKLY, FORTNIGHTLY, MONTHLY, BI_MONTHLY, TERM_TIME, ANUAL, NOT_STATED, OTHER}

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

        private DateTime dateAndTime;
        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

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
