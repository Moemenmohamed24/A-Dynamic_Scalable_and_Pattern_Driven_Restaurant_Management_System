using System;
using System.Xml.Linq;



public class PersonalData
{
    private string name = "";
    private string type = "";
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

        booking.AssigenType();

    }

    //Factory Method 
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
        Console.WriteLine($"Type is : {Type}");
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
        //we must treat that , because null , is dangerous   
        return null;
    }      
}

class Program
{
    static void Main(string[] args)
    {
        FullBooking fullBooking = new IndividualBooking();

        fullBooking.BookingOrder("individual");

    }
}