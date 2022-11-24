namespace BuilderDemo;

public class Product
{
    private string _requiredA = null!;
    private string _requiredB = null!;
    private int _optionalC;
    private string? _optionalD;

    public string RequiredA => _requiredA;
    public string RequiredB => _requiredB;
    public int OptionalC => _optionalC;
    public string? OptionalD => _optionalD;
    
    
    private Product(Builder builder)
    {
        _requiredA = builder._requiredA;
        _requiredB = builder._requiredB;
        _optionalC = builder._optionalC;
        _optionalD = builder._optionalD;
    }

    public override string ToString()
    {
        return $"{_requiredA}, {_requiredB}, {_optionalC}, {_optionalD}";
    }

    public class Builder
    {
        internal string _requiredA = null!;
        internal string _requiredB = null!;
        internal int _optionalC;
        internal string? _optionalD;
        
        public Builder(string requiredA, string requiredB)
        {
            _requiredA = requiredA;
            _requiredB = requiredB;
        }
        
        public Builder WithOptionalC(int optionalC)
        {
            _optionalC = optionalC;
            return this;
        }
        
        public Builder WithOptionalD(string? optionalD)
        {
            _optionalD = optionalD;
            return this;
        }
        
        public Product Build()
        {
            var product = new Product(this);
            if(_optionalC<0)
                throw new ArgumentException("OptionalC must be greater than 0");
            if (_optionalD.Equals(""))
                throw new ArgumentException("If u want to set OptionalD, it must be not empty");
            return product;
        }
    }
    
    
}