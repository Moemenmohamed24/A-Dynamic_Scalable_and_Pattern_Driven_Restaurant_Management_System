using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;


class Program
{
    static void Main(string[] args)
    {

       // FullBooking fullBooking = new CoupleBooking();
        FullBooking fullBooking = new GroupBooking();


        Booking booking = fullBooking.BookingOrder("Group");

        /*
        In other words, BGroup is also BPersonalData.

        This is a fundamental rule of inheritance:

        If BGroup inherits from BPersonalData, then any object of type BGroup can also be considered BPersonalData.

        if (myBooking is BPersonalData personalData)
            Here, the runtime asks:
        Does the actual object(BGroup) inherit from BPersonalData ?
        */

        if (booking is PersonalData bPersonalData)
        {
            //  bPersonalData.AddExtrSeats(2);
            bPersonalData.UpgradeSeats();

        }
        //casting BPersonalData personalData = (BPersonalData)myBooking; 



        //Tableseats oder1 = new SimpleTable();
        //oder1 = new Centerpieces(oder1);
        //oder1 = new LightCandle(oder1);
        //oder1 = new Tablecloth(oder1);
        //oder1 = new ColorsTheme(oder1);
        //Console.WriteLine($" all sheap of tabel : {oder1.Discribtion()} \n  cost of the tabel = {oder1.getPrice()} $ ");



        //PaymentInterface Sterategy = new BankTransferPayment();
        //PaymentProcessor process = new PaymentProcessor(Sterategy);
        //process.Pay(4);


    }
}

