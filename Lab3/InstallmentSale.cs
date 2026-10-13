namespace Lab3
{
    public class InstallmentSale : CarSale
    {
        public override void CalculateFinalPrice()
        {
            FinalPrice = BasePrice; // Без змін при розтермінуванні
        }

        public override void SetInsuranceAndService()
        {
            InsuranceScheme = "Базове страхування відповідальності";
            WarrantyService = "Стандартна гарантія на 3 роки з щорічним ТО";
        }
    }
}