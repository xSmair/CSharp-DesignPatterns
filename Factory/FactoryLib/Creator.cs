namespace Factory;

public class Creator
{
    public Product FirstFactoryMethod()
    {
        return DateTime.Now.Second % 2 == 0 ? new ConcreteProductA() : new ConcreteProductB();
    }

    public Product FactoryMethod(string productType)
    {
        return productType.ToUpper() == "A" ? new ConcreteProductA() : new ConcreteProductB();
    }
}