namespace ProvaPub.Models
{
    public class PayOrderWithPayPal : Payment
    {
        public PayOrderWithPayPal()
        {
        }

        public override async Task<Order> PayOrder(decimal paymentValue, int customerId)
        {
            //Comportamento para pagamento com PIX

            return await Task.FromResult(new Order()
            {
                Id = 3,
                Value = paymentValue
            });
        }
    }
}