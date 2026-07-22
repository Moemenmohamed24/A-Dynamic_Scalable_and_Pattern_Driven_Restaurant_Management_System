public class LightCandle : TableDecorator
{
    public LightCandle(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " LightCandle ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 5;
    }
}

