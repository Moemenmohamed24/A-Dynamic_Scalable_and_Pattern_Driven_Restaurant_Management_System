using System;
using System.Xml.Linq;



public class PersonalData
{
    private string name = "";
    private string type = "";
    private short numberofseats = 4;
    public string   Name { get
        {
            return this.name;
        }
       
        set
        {
            name = value;
        }
    
    }
    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            type = value;
        }
    }
    public short Numberofseats
    {
        get
        {
            return numberofseats;
        }

        set
        {
            numberofseats = value;
        }

    }

}

public interface Booking
{
    //defualt virtual function interface
        void AssigenType();

}


// ========================================== 
// Creator , that make final creation of product 
// ==========================================

public abstract class FullBooking 
{
   
    public void BookingOrder(string type)
    {
        Booking booking  = creatBooking(type);

        if(booking!=null)
        {
          booking.AssigenType();

        }

        

    }

    //Factory Method 
    //return type of types Booking like Individual , Family and  Couple
    protected abstract Booking creatBooking(string type);
}

// ========================================== 
//  Concrete Products 
// ==========================================

public class Individual : PersonalData ,  Booking
{

    public void AssigenType()
    {
        Type = "individual";
        Numberofseats = 1;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}"  );
    }     
}


public class Family : PersonalData  , Booking
{
    public void AssigenType()
    {
        Type = "Family";        
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }

}


public class Couple : PersonalData , Booking
{
    public void AssigenType()
    {
        Type = "Couple";
        Numberofseats = 2;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }
}

// ==========================================
// Concrete Creators 
// ========================================== 

public class IndividualBooking : FullBooking
{
    protected override Booking creatBooking(string type)
    {
        if(type == "individual")
        {
            return new Individual();
        }       
        throw new ArgumentException("Invalid booking type");
    }      
}
public class FamilyBooking : FullBooking
{
    protected override Booking creatBooking(string type)
    {
        if (type == "Family")
        {
            return new Family();
        }
        throw new ArgumentException("Invalid booking type");
    }
}
public class CoupleBooking : FullBooking
{
    protected override Booking creatBooking(string type)
    {
        if(type == "Couple")
        {
            return new Couple();
        }
        throw new ArgumentException();
    }
}


class Program
{
    static void Main(string[] args)
    {
        //FullBooking fullBooking = new IndividualBooking();

        //FullBooking fullBooking = new FamilyBooking();

        FullBooking fullBooking = new CoupleBooking();

        //fullBooking.BookingOrder("individual");              
        //fullBooking.BookingOrder("Family");
        fullBooking.BookingOrder("Couple");

    }
}