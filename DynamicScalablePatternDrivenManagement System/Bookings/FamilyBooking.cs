
// ==========================================
// Concrete Creators 
// ========================================== 


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
