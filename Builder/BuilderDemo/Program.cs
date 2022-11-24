using BuilderDemo;

var product = new Product.Builder("RequiredA", "RequiredB")
    .WithOptionalC(12)
    .WithOptionalD("OptionalD")
    .Build();
Console.WriteLine(product);

Console.WriteLine("Will throw an exception because we set OptionalC to not be lower than 0");
var product2 = new Product.Builder("asd", "asdddd").WithOptionalC(-1).Build();


