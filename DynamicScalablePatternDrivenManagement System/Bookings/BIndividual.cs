
// ========================================== 
//  Concrete Products 
// ==========================================

public class BIndividual : BPersonalData,  Booking
{

    public void AssigenType()
    {
        Type = "individual";
        Numberofseats = 1;
         
        Console.WriteLine($"Type is : {Type}   Numberofseats : {Numberofseats}"  );
    }     
}
