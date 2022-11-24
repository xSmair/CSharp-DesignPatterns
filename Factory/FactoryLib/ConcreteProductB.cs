namespace Factory;

internal class ConcreteProductB : Product
{
    public override string DoIt()
    {
        return "B";
    }

    public override string DoThat()
    {
        return "WHERE IS MY LISI?!";
    }
}