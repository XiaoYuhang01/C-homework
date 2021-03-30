using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();
            clock1.tick += () => { Console.WriteLine("Tick"+clock1.getHour+":"+clock1.getMinute+":"+clock1.getSecond); };

            clock1.alarm += () => { if (clock1.getHour == 0&&clock1.getMinute == 0&&clock1.getSecond == 0) { Console.WriteLine("alarm"); } };
            clock1.StartClock(23, 59, 50);
        }
    }
}
