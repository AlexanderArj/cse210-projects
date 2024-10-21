using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }

    public string GetName()
    {
        return _productName;
    }
    public int GetId() {
        return _productId;
    }

}
