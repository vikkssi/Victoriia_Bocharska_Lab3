namespace Lab3
{
    public class CreditCreator : Creator
    {
        public override CarSale FactoryMethod()
        {
            return new CreditSale();
        }
    }
}