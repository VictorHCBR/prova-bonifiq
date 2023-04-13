namespace ProvaPub.Models
{
    public class PayOrderWithCreditCard : Payment
    {
        public PayOrderWithCreditCard()
        {
        }

        public override async Task<Order> PayOrder(decimal paymentValue, int customerId)
        {
            //Comportamento para pagamento com PIX

            return await Task.FromResult(new Order()
            {
                Id = 2,
                Value = paymentValue
            });
        }
    }
}