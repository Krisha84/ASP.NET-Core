using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestE
{
    internal class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public Time(int hours = 0, int minutes = 0, int seconds = 0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
            NormalizeTime();
        }

        public Time(Time other)
        {
            Hours = other.Hours;
            Minutes = other.Minutes;
            Seconds = other.Seconds;
        }

        private void NormalizeTime()
        {
            Minutes += Seconds / 60;
            Seconds %= 60;
            Hours += Minutes / 60;
            Minutes %= 60;
        }

        public Time Add(Time other)
        {
            return new Time(Hours + other.Hours, Minutes + other.Minutes, Seconds + other.Seconds);
        }
        public void Display()
        {
            Console.WriteLine(Hours + ":" + Minutes + ":" + Seconds);
        }

    }
}
