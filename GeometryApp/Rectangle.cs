using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryApp
{
    internal class Rectangle
    {
        internal class Time
        {
            private int hour;
            private int minute;
            private int second;

            public int Hour
            {
                get { return hour; }
                set
                {
                    if (value >= 0)
                    {
                        hour = value;
                    }
                }
            }

            public int Minute
            {
                get { return minute; }
                set
                {
                    if (value >= 0)
                    {
                        minute = value;
                    }
                }
            }

            public int Second
            {
                get { return second; }
                set
                {
                    if (value >= 0)
                    {
                        second = value;
                    }
                }
            }

            public Time()
            {
                Hour = 0;
                Minute = 0;
                Second = 0;
            }

            public Time(int hour, int minute, int second)
            {
                Hour = hour;
                Minute = minute;
                Second = second;
            }

            public void ShowTime()
            {
                Console.WriteLine($"{Hour:D2}:{Minute:D2}:{Second:D2}");
            }
        }
    }
}
