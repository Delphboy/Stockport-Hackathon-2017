using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockport_Hackathon.classes
{
    class Activity
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string postcode;
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        private DateTime dateAndTime;
        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }
    }
}
