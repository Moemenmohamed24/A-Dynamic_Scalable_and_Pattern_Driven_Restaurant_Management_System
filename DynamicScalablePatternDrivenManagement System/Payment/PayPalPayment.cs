public class PayPalPayment : PaymentInterface
{
    public void Pay(decimal amount) 
    {
     
        Console.WriteLine("paypal...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

