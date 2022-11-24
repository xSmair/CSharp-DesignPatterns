namespace Factory;

internal class ConcreteProductA:Product
{
    public override string DoIt()
    {
        return "A";
    }

    public override string DoThat()
    {
        return "A!!!";
    }
}