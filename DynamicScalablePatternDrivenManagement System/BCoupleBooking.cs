
// ==========================================
// Concrete Creators 
// ========================================== 





public class BCoupleBooking : BFullBooking
{
    protected override Booking creatBooking(string type)
    {
        if(type == "Couple")
        {
            return new BCouple();
        }
        throw new ArgumentException();
    }
}
