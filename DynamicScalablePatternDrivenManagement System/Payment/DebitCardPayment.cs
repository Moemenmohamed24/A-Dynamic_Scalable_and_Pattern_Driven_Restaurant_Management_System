public class DebitCardPayment : PaymentInterface
{
    public void Pay(decimal amount)
    {

        Console.WriteLine("DebitCard...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

