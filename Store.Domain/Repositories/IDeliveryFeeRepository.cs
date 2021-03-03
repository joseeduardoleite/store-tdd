namespace Store.Domain.Repositories
{
    public interface IDeliveryFeeRepository
    {
         double Get(string zipCode);
    }
}