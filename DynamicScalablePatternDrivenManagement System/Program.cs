using System;
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
        fullBooking.BookingOrder("Group");


    }
}