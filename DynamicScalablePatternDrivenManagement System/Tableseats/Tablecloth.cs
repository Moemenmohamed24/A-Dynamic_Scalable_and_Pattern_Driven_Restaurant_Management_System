public class Tablecloth : TableDecorator
{

    public Tablecloth(Tableseats tableseats) : base(tableseats)
    {

    }


    public override string Discribtion()
    {
        return tableseats.Discribtion() + " tablecloth ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 7;
    }


}

