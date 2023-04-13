namespace ProvaPub.Models
{
    public abstract class Payment
    {
        public abstract Task<Order> PayOrder(decimal paymentValue, int customerId);
    }
}
