using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

// abstract class  of all class that make adding 
public abstract class Tableseats
{
    public abstract string Discribtion();
    public abstract int getPrice();
}



public class TSimpleTable : Tableseats
{ 
    public override string Discribtion()
    {
        return "SimpleTable";
    }

    public override int getPrice()
    {
        return 0;
    }

}

// Remains abstract because it does not implement the inherited abstract methods from Tableseats.
// This tells the compiler that the class is incomplete and cannot be instantiated.
// Concrete decorators will provide the actual implementations.
//TableDecorator consider as proxy between Tableseats and additional and passing  the objects to make Chaine
public abstract class TableDecorator : Tableseats
{
    protected Tableseats tableseats;

    public TableDecorator(Tableseats tableseats)
    {
        this.tableseats = tableseats;
    }
}


public class TCenterpieces : TableDecorator
{
    //base for  push tableseats to  TableDecorator  constructor to make Chaine of decorator objects 
    public TCenterpieces(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " table with Centerpieces ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 10;
    }

}


public class TLightCandle : TableDecorator
{
    public TLightCandle(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " LightCandle ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 5;
    }
}

public class Tablecloth : TableDecorator
{

    public Tablecloth(Tableseats tableseats) : base(tableseats)
    {

    }


    public override string Discribtion()
    {
        return tableseats.Discribtion() + " tablecloth ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 7;
    }


}

public class TColorsTheme : TableDecorator
{
    public TColorsTheme(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " ColorsTheme .";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 10;
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



        Tableseats oder1 = new TSimpleTable();
        oder1 = new TCenterpieces(oder1);
        oder1 = new TLightCandle(oder1);
        oder1 = new Tablecloth(oder1);
        oder1 = new TColorsTheme(oder1);



        Console.WriteLine($" all sheap of tabel : {oder1.Discribtion()} \n  cost of the tabel = {oder1.getPrice()} ");



    }
}

