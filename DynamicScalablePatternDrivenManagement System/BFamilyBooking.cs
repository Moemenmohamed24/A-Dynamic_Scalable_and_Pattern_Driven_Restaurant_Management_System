
// ==========================================
// Concrete Creators 
// ========================================== 


public class BFamilyBooking : BFullBooking
{
    protected override Booking creatBooking(string type)
    {
        if (type == "Family")
        {
            return new BFamily();
        }
        throw new ArgumentException("Invalid booking type");
    }
}
