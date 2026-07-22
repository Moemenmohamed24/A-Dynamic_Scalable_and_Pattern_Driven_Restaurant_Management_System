
// ==========================================
// Concrete Creators 
// ========================================== 





public class GroupBooking : FullBooking
{
    protected override Booking creatBooking(string type)
    {
        if (type == "Group")
        {
            return new Group();
        }
        throw new ArgumentException("Invalid booking type");
    }

}
