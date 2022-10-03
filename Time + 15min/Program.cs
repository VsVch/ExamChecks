using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            int min2 = min + 15;

            if (min2 > 59 )
            {
                min2 = min2 % 60;
                hour = hour + 1;
                if (hour > 23)
                {
                    hour = 0;
                }
                if (min2<10)
                {
                    Console.WriteLine($"{ hour}:0{ min2}");
                }
                else 
                {
                    Console.WriteLine($"{ hour}:{ min2}");
                }
                
                
            }
            else
            {
                Console.WriteLine($"{ hour}:{ min2}");
            }




           // else
           // {
            //    Console.WriteLine($"{ hour}:{ min2}");
           // }

           
          //  Console.WriteLine($"{ hour}:0{ min2}");
          //  Console.WriteLine(min2);

        }
    }
}
