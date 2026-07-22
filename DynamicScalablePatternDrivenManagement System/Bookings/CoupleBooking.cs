
// ==========================================
// Concrete Creators 
// ========================================== 





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
