using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        { 

            // 1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            // 2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double worldRecord = double.Parse(Console.ReadLine());
            double distnce = double.Parse(Console.ReadLine());
            double timeForMetre = double.Parse(Console.ReadLine());

            double timeForDistance = distnce * timeForMetre;
            double fullTimeForDistance = 0.00;
            double waterStoped = 0.00;
            waterStoped = distnce / 15;
            waterStoped = Math.Floor(waterStoped);
            fullTimeForDistance = waterStoped * 12.5;

            if (distnce>15)
            {
                
               // fullTimeForDistance = Math.Round(fullTimeForDistance);
                //Console.WriteLine(fullTimeForDistance);
                fullTimeForDistance = fullTimeForDistance + timeForDistance;

            }
            else
            {
                fullTimeForDistance = fullTimeForDistance + timeForDistance;
            }

            if (worldRecord> fullTimeForDistance)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTimeForDistance:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(fullTimeForDistance-worldRecord):f2} seconds slower.");
            }
                 




        }
    }
}
