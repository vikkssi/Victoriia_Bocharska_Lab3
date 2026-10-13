namespace Lab3
{
    public class FullPaymentCreator : Creator
    {
        public override CarSale FactoryMethod()
        {
            return new FullPaymentSale();
        }
    }
}