using System;

namespace BeerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int PriceHoegarden = 70;
            int PriceLeffe = 80;
            int PriceStella = 60;
            int PriceObolon = 7;
            int MinSum = 6;

            Console.WriteLine("Магазин BeerShop");
            Console.WriteLine("Какую сумму готовы потратить?");

            int money = Convert.ToInt32(Console.ReadLine());

            if (money <= MinSum)
            {
                Console.WriteLine("Вашей суммы не достаточно для совершения покупок :(((");
            }
               else if (money > PriceLeffe)
                {
                int sum = money - PriceLeffe;
                Console.WriteLine($"Лучшим выбором для вас будет Leffe. Сдача= {sum}");
                }

                  if (money <= PriceLeffe && money >= PriceHoegarden)
                   {
                   int sum = money - PriceHoegarden;
                   Console.WriteLine($"Лучшим выбором для вас будет Hoegarden. Сдача= {sum}");
                   }
                     else if (money < PriceHoegarden && money >= PriceStella)
                      {
                      int sum = money - PriceStella;
                      Console.WriteLine($"Лучшим выбором для вас будет Stella. Сдача= {sum}");
                      }
                         else if (money < PriceStella && money >= PriceObolon)
                          {
                          int sum = money - PriceObolon;
                          Console.WriteLine($"Лучшим выбором для вас будет Obolon. Сдача= {sum}");
                          }


            Console.WriteLine("____________________ Спасибо за покупку! _________________");


        }
    }
}
    

