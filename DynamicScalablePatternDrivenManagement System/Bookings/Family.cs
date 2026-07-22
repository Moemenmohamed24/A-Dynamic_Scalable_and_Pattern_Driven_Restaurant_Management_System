// ========================================== 
//  Concrete Products 
// ==========================================



public class Family : PersonalData, Booking
{
    public void AssigenType()
    {
        Type = "Family";        
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }

}
