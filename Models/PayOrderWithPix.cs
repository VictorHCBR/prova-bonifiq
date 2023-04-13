namespace ProvaPub.Models
{
    public class PayOrderWithPix : Payment
    {
        public PayOrderWithPix()
        {
        }

        public override async Task<Order> PayOrder(decimal paymentValue, int customerId)
        {
            //Comportamento para pagamento com PIX

            return await Task.FromResult(new Order()
            {
                Id = 1,
                Value = paymentValue
            });
        }
    }
}
