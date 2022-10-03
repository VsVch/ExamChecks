using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int sumTime = time1 + time2 + time3;
            double min = sumTime / 60;
            double sec = sumTime % 60;
            //Console.WriteLine(min);
            //Console.WriteLine(sec);
            if (sec<10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }


        }
    }
}
