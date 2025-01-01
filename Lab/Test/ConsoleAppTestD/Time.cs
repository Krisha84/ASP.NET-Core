using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestD
{
    internal class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Time(Time time)
        {
            this.Hours = time.Hours;
            this.Minutes = time.Minutes;
            this.Seconds = time.Seconds;
        }

        public void AddTime(Time time)
        {
            this.Seconds += time.Seconds;
            if (this.Seconds >= 60)
            {
                this.Seconds -= 60;
                this.Minutes++;
            }

            this.Minutes += time.Minutes;

            if (this.Minutes >= 60)
            {
                this.Minutes -= 60;
                this.Hours++;
            }

            this.Hours += time.Hours;
        }

        public void DisplayTime()
        {
            Console.WriteLine("Time => " + Hours + ":" + Minutes + ":" + Seconds);
        }
    }
}
