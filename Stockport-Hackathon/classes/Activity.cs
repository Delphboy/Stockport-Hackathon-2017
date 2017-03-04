using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bing.Maps;

namespace Stockport_Hackathon.classes
{
    public enum weatherList { SUN, WIND, RAIN, STORM}
    public enum activityDay{ MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY}
    public enum activityType { PHYSICAL, HEALTH, CREATIVE, LEISURE}

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

        private string venue;
        public string Venue
        {
            get { return venue; }
            set { venue = value; } 
        }

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

        private string postcode;
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
    }
}
