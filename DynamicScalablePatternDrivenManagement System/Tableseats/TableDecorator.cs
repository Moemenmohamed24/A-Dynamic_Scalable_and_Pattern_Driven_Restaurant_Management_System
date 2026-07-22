
// Remains abstract because it does not implement the inherited abstract methods from Tableseats.
// This tells the compiler that the class is incomplete and cannot be instantiated.
// Concrete decorators will provide the actual implementations.
//TableDecorator consider as proxy between Tableseats and additional and passing  the objects to make Chaine
public abstract class TableDecorator : Tableseats
{
    protected Tableseats tableseats;

    public TableDecorator(Tableseats tableseats)
    {
        this.tableseats = tableseats;
    }
}

