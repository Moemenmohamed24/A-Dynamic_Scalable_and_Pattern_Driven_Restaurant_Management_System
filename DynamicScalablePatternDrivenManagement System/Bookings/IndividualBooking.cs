
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
