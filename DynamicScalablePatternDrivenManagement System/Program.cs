using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

// Interface  of all class that make adding 
public interface Tableseats
{
    public string Discribtion();
    public short getPrice();
}


public class SimpleTable : Tableseats
{ 
    public override string Discribtion()
    {
        return "SimpleTable";
    }

    public override short getPrice()
    {
        return 0;
    }

}







class Program
{
    static void Main(string[] args)
    {
        
       // FullBooking fullBooking = new CoupleBooking();
       BFullBooking fullBooking = new BGroupBooking();


        Booking booking = fullBooking.BookingOrder("Group");

        /*
        In other words, BGroup is also BPersonalData.

        This is a fundamental rule of inheritance:

        If BGroup inherits from BPersonalData, then any object of type BGroup can also be considered BPersonalData.

        if (myBooking is BPersonalData personalData)
            Here, the runtime asks:
        Does the actual object(BGroup) inherit from BPersonalData ?
        */

        if (booking is BPersonalData bPersonalData)
        {
            //  bPersonalData.AddExtrSeats(2);
            bPersonalData.UpgradeSeats();           

        }       
        //casting BPersonalData personalData = (BPersonalData)myBooking; 




    }
}