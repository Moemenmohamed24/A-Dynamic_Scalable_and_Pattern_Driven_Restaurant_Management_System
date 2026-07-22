// ========================================== 
//  Concrete Products 
// ==========================================



public class BCouple : BPersonalData, Booking
{
    public void AssigenType()
    {
        Type = "Couple";
        Numberofseats = 2;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }
}
