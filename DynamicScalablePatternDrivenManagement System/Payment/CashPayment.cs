public class CashPayment : PaymentInterface
{
    public void Pay(decimal amount)
    {

        Console.WriteLine("Cash...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

