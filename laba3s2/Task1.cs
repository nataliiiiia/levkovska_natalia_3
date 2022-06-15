using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3s2
{
    // Hours, Minutes - class; Hour, Minute - property; hour, minute - fields
    public class Hours
    {
        private int hour;
        public int Hour
        {
            set
            {
                if (value >= 0 && value <= 24)
                {
                    hour = value;
                }
                else hour = 12;
            }
            get { return hour; }
            
        }
        
    }
    public class Minutes 
    {
        private int minute;
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    minute = value;
                }
                else minute = 30;

            }
        }
    }
    public class Day  
    {
        public int hours;
        public int minutes;
        public override string ToString()
        {
            if (minutes < 10)
                return $"The time is: {hours}:0{minutes}";
            else
                return $"The time is: {hours}:{minutes}";

        }
        public string DayTime()
        {
            string dt;
            if (hours >= 0 && hours < 6)
            {
                dt = "night";
            }
            else if (hours >= 6 && hours < 12)
            {
                dt = "morning";
            }
            else if (hours >= 12 && hours <= 16)
            {
                dt = "afternoon";
            }
            else if (hours > 16 && hours <= 21)
            {
                dt = "evening";
            }
            else dt = "night";
            return dt;
        }
    }
}
