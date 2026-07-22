// ========================================== 
//  Concrete Products 
// ==========================================
public class BGroup : BPersonalData, Booking
{

    public void AssigenType()
    {
        Type = "Group";
        Numberofseats = 4;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }
} 
