public class PaymentProcessor
{
    PaymentInterface paymentInterface;

    public PaymentProcessor(PaymentInterface paymentInterface)
    {
        this.paymentInterface = paymentInterface;
    }

    public void SetStrategy(PaymentInterface paymentInterface)
    {
        this.paymentInterface = paymentInterface;

    }

    public void Pay(decimal amount)
    {
        paymentInterface.Pay(amount);
    }
}

