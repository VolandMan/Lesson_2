using System;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            double SaleSum;
            double Rezalt;

            Console.WriteLine("Введите сумму покупки и нажмите Enter:");

            double sum = Convert.ToInt32(Console.ReadLine());

          if (sum > 0 && sum <= 300)
           {
                Console.WriteLine("Скидка не предусмотрена");
           }
               else if (sum > 300 && sum <= 400)
               {
                SaleSum = (sum / 100) * 2;
                Rezalt = sum - SaleSum;
                Console.WriteLine($"Сумма без скидки={sum}. Сумма со скидкой 2% = {Rezalt}");
               }

                  else if (sum > 400 && sum <= 500)
                   {
                   SaleSum = (sum / 100) * 3;
                   Rezalt = sum - SaleSum;
                   Console.WriteLine($"Сумма без скидки={sum}. Сумма со скидкой 3% = {Rezalt}");
                   }

                else if (sum > 500)
                 {
                 SaleSum = (sum / 100) * 5;
                 Rezalt = sum - SaleSum; 
                 Console.WriteLine($"Сумма без скидки={sum}. Сумма со скидкой 5% = {Rezalt}");
                 }
            Console.WriteLine("____________________ Спасибо за покупку! _________________");
        }
    }
}

