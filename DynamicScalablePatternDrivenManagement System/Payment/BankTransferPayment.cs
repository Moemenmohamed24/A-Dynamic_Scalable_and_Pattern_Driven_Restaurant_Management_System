public class BankTransferPayment : PaymentInterface
{

    public void Pay(decimal amount)
    {
        Console.WriteLine("BankTransfer...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

