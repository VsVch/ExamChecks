using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            double num2 = 0.0;
            if (first == "m")
            {
                if (second == "cm")
                {
                    num2 = num * 100;
                    
                }
                else if (second == "mm")
                {
                    num2 = num * 1000;
                }
            }
            else if (first == "cm")
            {
                if (second == "mm")
                {
                    num2 = num * 10;
                }
                else if (second == "m")
                {
                    num2 = num / 100;
                }
            }
            else if (first == "mm")
            {
                if (second == "cm")
                {
                    num2 = num / 10;
                }
                else if (second == "m")
                {
                    num2 = num / 1000;
                }
            }

            Console.WriteLine($"{num2:F3}");
            //Console.WriteLine(  num2);



        }
    }
}
