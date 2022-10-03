using System;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            double bonus = 0.00;


            if (num <= 100)
            {
                bonus = bonus + 5;
            }
            else if (num > 1000)
            {
                bonus = num * 10 / 100;
            }
            else
            {
                bonus = num * 20 / 100;
            }






            if (num % 2 == 0)
            {
                bonus = bonus + 1;

            }

            if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }
            //Console.WriteLine(bonus);

            

            double sum = num + bonus;


            Console.WriteLine(bonus);
            Console.WriteLine(sum);

        }
    }
}
