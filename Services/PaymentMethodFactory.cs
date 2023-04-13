using ProvaPub.Models;

namespace ProvaPub.Services
{
    public class PaymentMethodFactory
    {
        public static Payment Instantiate(string paymentMethod)
        {
            paymentMethod = paymentMethod.ToUpper().Trim();

            switch (paymentMethod)
            {
                case "PIX":
                    return new PayOrderWithPix();

                case "CARTAO DE CREDITO":
                    return new PayOrderWithCreditCard();

                case "PAYPAL":
                    return new PayOrderWithPayPal();

                default:
                    throw new Exception("This payment method is not supported!");
            }
        }
    }
}
