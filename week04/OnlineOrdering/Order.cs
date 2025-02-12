public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
        public Order(Customer customer, Product product)
    {
        _products.Add(product);
        _customer = customer;
    }
        public Order(Customer customer, Product product, Product product1)
    {
        _products.Add(product);
        _products.Add(product1);
        _customer = customer;
    }
    public Order(Customer customer, Product product, Product product1, Product product2)
    {
        _products.Add(product);
        _products.Add(product1);
        _products.Add(product2);
        _customer = customer;
    }
    public Order(Product product)
    {
        _products.Add(product);
    }
    public double _total()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product._total();
        }
        return total;
    }
    public string _packingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product._getName()}, {product._getId()}\n";
        }
        return packingLabel.TrimEnd();
    }
    public string _shippingLabel()
    {
        return $"{_customer._getName()}, {_customer._getFullAddress()}";
    }
}