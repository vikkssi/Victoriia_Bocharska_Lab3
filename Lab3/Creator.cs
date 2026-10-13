namespace Lab3
{
    public abstract class Creator
    {
        public abstract CarSale FactoryMethod();

        public CarSale ProcessSale(string customerName, string brand, string model, int year, decimal basePrice)
        {
            CarSale sale = FactoryMethod();
            sale.CustomerName = customerName;
            sale.Brand = brand;
            sale.Model = model;
            sale.Year = year;
            sale.BasePrice = basePrice;

            sale.CalculateFinalPrice();
            sale.SetInsuranceAndService();

            return sale;
        }
    }
}