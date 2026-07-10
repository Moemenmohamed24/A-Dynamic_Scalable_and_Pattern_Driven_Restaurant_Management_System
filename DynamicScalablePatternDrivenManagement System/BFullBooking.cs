
// ========================================== 
// Creator , that make final creation of product 
// ==========================================

public abstract class BFullBooking 
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
