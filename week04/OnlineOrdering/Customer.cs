public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
{
    _name = name;
    _address = address;
}
    public bool _usLocated()
    {
        if (_address._usLocated())
        {
            return true;
        }
        else 
        {
            return false;
        }
    }

    public string _getFullAddress()
    {
        return _address._getFullAddress();
    }
    public string _getName()
    {
        return _name;
    }
}