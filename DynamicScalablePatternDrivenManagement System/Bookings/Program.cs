using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;


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

public interface PaymentInterface
{
    public void Pay(decimal amount);
}

public class CreditCardPayment : PaymentInterface
{
    public void Pay(decimal amount)
    {           
        Console.WriteLine("card...");
        Console.WriteLine("validation...");
        Console.WriteLine("withdrow: " + amount);
        Console.WriteLine("done pay. ");
    }
}

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


class Program
{
    static void Main(string[] args)
    {

        // FullBooking fullBooking = new CoupleBooking();
        //BFullBooking fullBooking = new BGroupBooking();


        // Booking booking = fullBooking.BookingOrder("Group");

        /*
        In other words, BGroup is also BPersonalData.

        This is a fundamental rule of inheritance:

        If BGroup inherits from BPersonalData, then any object of type BGroup can also be considered BPersonalData.

        if (myBooking is BPersonalData personalData)
            Here, the runtime asks:
        Does the actual object(BGroup) inherit from BPersonalData ?
        */

        //if (booking is BPersonalData bPersonalData)
        //{
        //    //  bPersonalData.AddExtrSeats(2);
        //    bPersonalData.UpgradeSeats();           

        //}
        ////casting BPersonalData personalData = (BPersonalData)myBooking; 



        //Tableseats oder1 = new TSimpleTable();
        //oder1 = new TCenterpieces(oder1);
        //oder1 = new TLightCandle(oder1);
        //oder1 = new Tablecloth(oder1);
        //oder1 = new TColorsTheme(oder1);

        //Console.WriteLine($" all sheap of tabel : {oder1.Discribtion()} \n  cost of the tabel = {oder1.getPrice()} ");

        PaymentInterface Sterategy = new BankTransferPayment();

        PaymentProcessor process = new PaymentProcessor(Sterategy);

        process.Pay(4);


    }
}

