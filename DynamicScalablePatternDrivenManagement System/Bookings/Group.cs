// ========================================== 
//  Concrete Products 
// ==========================================
public class Group : PersonalData, Booking
{

    public void AssigenType()
    {
        Type = "Group";
        Numberofseats = 4;
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}");
    }
} 
