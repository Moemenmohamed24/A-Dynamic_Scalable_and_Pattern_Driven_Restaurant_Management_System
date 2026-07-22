public class Centerpieces : TableDecorator
{
    //base for  push tableseats to  TableDecorator  constructor to make Chaine of decorator objects 
    public Centerpieces(Tableseats tableseats) : base(tableseats)
    {

    }

    public override string Discribtion()
    {
        return tableseats.Discribtion() + " table with Centerpieces ,";
    }

    public override int getPrice()
    {
        return tableseats.getPrice() + 10;
    }

}

