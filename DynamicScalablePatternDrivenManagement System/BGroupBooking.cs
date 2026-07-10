
// ==========================================
// Concrete Creators 
// ========================================== 





public class BGroupBooking : BFullBooking
{
    protected override Booking creatBooking(string type)
    {
        if (type == "Group")
        {
            return new BGroup();
        }
        throw new ArgumentException("Invalid booking type");
    }

}
