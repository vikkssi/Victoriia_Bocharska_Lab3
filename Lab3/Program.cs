using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Клієнт 1: Повна оплата
            Creator fullPaymentCreator = new FullPaymentCreator();
            CarSale fullPaymentSale = fullPaymentCreator.ProcessSale(
                "Іван Петренко", "Toyota", "Camry", 2026, 35000m);
            fullPaymentSale.DisplayInfo();

            Console.WriteLine(new string('-', 50));

            // Клієнт 2: Покупка у кредит
            Creator creditCreator = new CreditCreator();
            CarSale creditSale = creditCreator.ProcessSale(
                "Марія Шевченко", "BMW", "X5", 2026, 75000m);
            creditSale.DisplayInfo();

            Console.WriteLine(new string('-', 50));

            // Клієнт 3: Покупка з розтермінуванням
            Creator installmentCreator = new InstallmentCreator();
            CarSale installmentSale = installmentCreator.ProcessSale(
                "Олександр Коваль", "Renault", "Duster", 2026, 22000m);
            installmentSale.DisplayInfo();

            Console.ReadKey();
        }
    }
}