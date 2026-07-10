// ========================================== 
//  Concrete Products 
// ==========================================



public class BFamily : BPersonalData, Booking
{
    public void AssigenType()
    {
        Type = "Family";        
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }

}
