
// ==========================================
// Concrete Creators 
// ========================================== 

public class BIndividualBooking : BFullBooking
{
    protected override Booking creatBooking(string type)
    {
        if(type == "individual")
        {
            return new BIndividual();
        }       
        throw new ArgumentException("Invalid booking type");
    }      
}
