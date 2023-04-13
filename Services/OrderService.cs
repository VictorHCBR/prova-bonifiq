using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class OrderService
    {

        public async Task<Order> Pay(string paymentMethod, decimal paymentValue, int customerId)
        {
            var payment = PaymentMethodFactory.Instantiate(paymentMethod);

            return await payment.PayOrder(paymentValue, customerId);
        }
    }
}