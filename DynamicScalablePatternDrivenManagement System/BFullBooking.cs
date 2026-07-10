
// ========================================== 
// Creator , that make final creation of product 
// ==========================================

public abstract class BFullBooking 
{
   
    public Booking BookingOrder(string type)
    {
        Booking booking  = creatBooking(type);

        if(booking!=null)
        {
          booking.AssigenType();

        }

        return booking;
    }

    //Factory Method 
    //return type of types Booking like Individual , Family and  Couple
    protected abstract Booking creatBooking(string type);
}
