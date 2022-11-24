using BuilderDemo;

var product = new Product.Builder("RequiredA", "RequiredB")
    .WithOptionalC(12)
    .WithOptionalD("OptionalD")
    .Build();
Console.WriteLine(product);

