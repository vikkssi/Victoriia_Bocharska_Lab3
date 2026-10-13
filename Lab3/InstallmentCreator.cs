namespace Lab3
{
    public class InstallmentCreator : Creator
    {
        public override CarSale FactoryMethod()
        {
            return new InstallmentSale();
        }
    }
}