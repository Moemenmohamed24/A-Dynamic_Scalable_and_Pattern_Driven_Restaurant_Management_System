public class BPersonalData
{
    private string name = "";
    private string type = "";
    private short numberofseats = 4;
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

}
