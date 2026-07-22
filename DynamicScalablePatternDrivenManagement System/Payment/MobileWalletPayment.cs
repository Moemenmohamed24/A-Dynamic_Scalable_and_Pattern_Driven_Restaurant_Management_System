public class MobileWalletPayment : PaymentInterface
{
    public void Pay(decimal amount)
    {

        Console.WriteLine("MobileWallet...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

