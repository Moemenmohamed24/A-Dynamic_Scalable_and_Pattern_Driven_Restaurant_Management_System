public class ColorsTheme : TableDecorator
{
    public ColorsTheme(Tableseats tableseats) : base(tableseats)
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

