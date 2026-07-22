// ========================================== 
//  Concrete Products 
// ==========================================



public class Couple : PersonalData, Booking
{
    public void AssigenType()
    {
        Type = "Couple";
        Numberofseats = 2;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }
}
