public class TColorsTheme : TableDecorator
{
    public TColorsTheme(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " ColorsTheme .";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 10;
    }
}

