using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            string[] times = new string[6];
            times = s.Split(':');
            long[] time = new long[6];
            for (int i = 0; i < 6; i++) long.TryParse(times[i], out time[i]);
            long tick;
            long.TryParse(Console.ReadLine(), out tick);

            tick = tick / 10000000;
            time[5] += tick;
            for(int i = 0; i < 2; i++)
            {
                long temp = time[5 - i];
                time[5 - i] = temp % 60;
                time[5 - i - 1] = time[5 - i - 1] + (temp / 60);

            }

            if(time[3] > 24) { time[0] += time[3]/24; time[3] %= 24; }
            if(time[0] > 30) { time[1] += time[0] / 30; time[0] %= 30; }
            if (time[1] > 12) { time[2] += time[1] /12; time[1] %= 12; }

            for (int i = 0; i < 6; i++) Console.Write(time[i] + ":");
            Console.Read();
        }
    }
}
