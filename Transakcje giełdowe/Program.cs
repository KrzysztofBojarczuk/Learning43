using System;

namespace Transakcje_giełdowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSahresPurchosed = 1000;
            double priceBoughtPerShare = 32.87;
            double amountPaidForStock = numberOfSahresPurchosed * priceBoughtPerShare;
            double comissionForBuying = 0.02 * amountPaidForStock;

            int numberOfSharesSold = 1000;
            double pricesSoldPerShare = 33.92;
            double amountReceviedForStock = numberOfSharesSold * pricesSoldPerShare;
            double comissionForSelling = 0.02 * amountReceviedForStock;

            double totalProfit = (amountReceviedForStock - comissionForSelling) - (amountPaidForStock - comissionForBuying);
            Console.WriteLine("Joe płaci za akcje: " + amountPaidForStock);
            Console.WriteLine("Joe za prowzję dla borkoera w trakcje kupna zapłacił: " + comissionForBuying);
            Console.WriteLine("Joe sprzedał akcję za: " + amountReceviedForStock);
            Console.WriteLine("Joe za prowzję dla borkera w momencie sprzedaży kacji zapłacił: " + comissionForSelling);
            Console.WriteLine("Zyski Joe to: " + totalProfit);
        }
    }
}
