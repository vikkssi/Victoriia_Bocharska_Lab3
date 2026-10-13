namespace Lab3
{
    public class CreditSale : CarSale
    {
        public override void CalculateFinalPrice()
        {
            FinalPrice = BasePrice * 1.03m; // Націнка 3% за кредитні умови
        }

        public override void SetInsuranceAndService()
        {
            InsuranceScheme = "Стандартне кредитне страхування (обов'язкове КАСКО)";
            WarrantyService = "Стандартна заводська гарантія на 3 роки";
        }
    }
}