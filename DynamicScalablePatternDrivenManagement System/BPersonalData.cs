public enum SeatsQuality { Standard , VIP, Premium }
public class BPersonalData
{
    private string name = "";
    private string type = "";
    private short numberofseats = 4;
    private SeatsQuality qualitySeats ;
    public string   Name { get
        {
            return this.name;
        }
       
        set
        {
            name = value;
        }
    
    }
    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            type = value;
        }
    }
    public short Numberofseats
    {
        get
        {
            return numberofseats;
        }

        set
        {
            numberofseats = value;
        }

    }


    public SeatsQuality QualitySeats
    {
        get { return qualitySeats; }
        set {qualitySeats = SeatsQuality.Standard;}
    }


    ///---------------update method--------------------
    public void AddExtrSeats(short seats)
    {
        Numberofseats += seats;
    }

    public void RemoveSeats(short seats)
    {
        Numberofseats -= seats;

    }

    public void UpgradeSeats()
    {
        SeatsQuality updatedSeatsQuality = GetSeatsQuality();

        if(updatedSeatsQuality != QualitySeats)
        {
            QualitySeats = updatedSeatsQuality;
            Console.WriteLine($"Successful UpgradequalitySeats to {updatedSeatsQuality}..");
        }
        else
        {
            Console.WriteLine("You are already on this quality.");
        }      
    }

    public SeatsQuality GetSeatsQuality()
    {
        Console.WriteLine($"choise updrade SeatsQuality [Standard , VIP, Premium ]...");
        Console.WriteLine($"[Standard = 1 , VIP = 2, Premium  = 3]");
        Console.WriteLine($"Inter number ");

        short number = short.Parse(Console.ReadLine());

        switch (number)
        {
            case 2: return SeatsQuality.VIP;
            case 3: return SeatsQuality.Premium;
            default: return SeatsQuality.Standard;
        }
    }
}
