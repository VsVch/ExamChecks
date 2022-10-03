using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            int numOfPeople = int.Parse(Console.ReadLine());
            double proceForClothes = double.Parse(Console.ReadLine());

            double decor = budjet*0.1;
            double discountForClothes = 0.0;
            if (numOfPeople>150)
            {
                discountForClothes = proceForClothes*0.1;
                proceForClothes = proceForClothes - discountForClothes;
            }


            double neededMoney = budjet - (decor + numOfPeople*proceForClothes);
            
            if (neededMoney < 0)
            {
                neededMoney = Math.Abs(neededMoney);
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
                

            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {neededMoney:f2} leva left.");

            }











        }
    }
}
