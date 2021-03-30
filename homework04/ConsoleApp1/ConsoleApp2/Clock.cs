using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Clock
    {
        private int hour, minute, second;

        public int getHour{ get =>hour; }
        public int getMinute { get => minute; }
        public int getSecond { get => second; }
        public delegate void A();

        public event A tick, alarm;

        public void StartClock(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
            while (true) {
                Thread.Sleep(1000);
                tick();
                Add();
                alarm();
            }

        }
        
        public void Add()
        {
            second++;
            if (second == 60) { minute++; second = 0; }
            if (minute == 60) { hour++; minute = 0; }
            if (hour == 24) { hour = 0; }
        }
    }
}
