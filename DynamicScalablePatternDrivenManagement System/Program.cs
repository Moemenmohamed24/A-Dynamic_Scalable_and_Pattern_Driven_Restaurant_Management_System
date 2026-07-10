using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Xml.Linq;


class Program
{
    static void Main(string[] args)
    {
        //FullBooking fullBooking = new IndividualBooking();

        //FullBooking fullBooking = new FamilyBooking();

       // FullBooking fullBooking = new CoupleBooking();
       BFullBooking fullBooking = new BGroupBooking();



        //fullBooking.BookingOrder("individual");              
        //fullBooking.BookingOrder("Family");



        Booking booking = fullBooking.BookingOrder("Group");




        if (booking is BPersonalData bPersonalData)
        {
            //  bPersonalData.AddExtrSeats(2);
            bPersonalData.UpgradeSeats();

        }

        //In other words, BGroup is also BPersonalData.

        //This is a fundamental rule of inheritance:

        //If BGroup inherits from BPersonalData, then any object of type BGroup can also be considered BPersonalData.

        //if (myBooking is BPersonalData personalData)
        //    Here, the runtime asks:
        //Does the actual object(BGroup) inherit from BPersonalData?

        //casting BPersonalData personalData = (BPersonalData)myBooking; 

    }
}