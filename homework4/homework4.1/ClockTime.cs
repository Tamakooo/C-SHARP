using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4._1
{
    class ClockTime
    {

        private int hour;
        private int minute;
        private int second;

        public ClockTime(int hour = 0, int minute = 0, int second = 0)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0 || value > 24) throw new ArgumentOutOfRangeException("invalid hour!");
                hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("minute invalid!");
                }
                minute = value;
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("invalid second!");
                }
                second = value;
            }
        }

        public override bool Equals(object obj)
        {
            var time = obj as ClockTime;
            return time != null &&
                   Hour == time.Hour &&
                   Minute == time.Minute &&
                   Second == time.Second;
        }

        public override int GetHashCode()
        {
            var hashCode = 1505761165;
            hashCode = hashCode * -1521134295 + Hour.GetHashCode();
            hashCode = hashCode * -1521134295 + Minute.GetHashCode();
            hashCode = hashCode * -1521134295 + Second.GetHashCode();
            return hashCode;
        }
    }
}
