namespace Lab3
{
    public class FullPaymentSale : CarSale
    {
        public override void CalculateFinalPrice()
        {
            FinalPrice = BasePrice * 0.95m; // Знижка 5%
        }

        public override void SetInsuranceAndService()
        {
            InsuranceScheme = "Преміум страхування (КАСКО у подарунок зі знижкою)";
            WarrantyService = "Розширена гарантія на 5 років без обмеження пробігу";
        }
    }
}