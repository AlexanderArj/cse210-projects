using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool LivesInUsa()
    {

        if ( _address.IsInUsa())
        {
            return true;
        }

        else
        {
            return false;
        }

    }

    public string GetName()
    {
        return _customerName;
    }
    public Address GetAddress()
    {
        return _address;
    }
    
}
