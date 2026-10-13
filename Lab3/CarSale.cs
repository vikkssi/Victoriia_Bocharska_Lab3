namespace Lab3
{
    public abstract class CarSale
    {
        public string CustomerName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal BasePrice { get; set; }

        public decimal FinalPrice { get; protected set; }
        public string InsuranceScheme { get; protected set; }
        public string WarrantyService { get; protected set; }

        public abstract void CalculateFinalPrice();
        public abstract void SetInsuranceAndService();

        public void DisplayInfo()
        {
            System.Console.WriteLine($"[БД Автосалону] Оформлення документації:");
            System.Console.WriteLine($" Покупець: {CustomerName}");
            System.Console.WriteLine($" Автомобіль: {Brand} {Model} ({Year} р.)");
            System.Console.WriteLine($" Базова ціна: {BasePrice} $");
            System.Console.WriteLine($" Кінцева ціна (з урахуванням умов): {FinalPrice} $");
            System.Console.WriteLine($" Схема страхування: {InsuranceScheme}");
            System.Console.WriteLine($" Гарантійне обслуговування: {WarrantyService}");
        }
    }
}