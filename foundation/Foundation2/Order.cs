public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double TotalCost()
    {
        double totalCost = 0;
        double shippingCost = 0;


        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        if ( _customer.LivesInUsa())
        {
            shippingCost = 5.0;
        }

        else
        {
            shippingCost = 35.0;
        }

        return totalCost + shippingCost;

    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label = label + product.GetName() + " (ID: " + product.GetId() + ")\n";
        }

        return label;
    
    }



    public string ShippingLabel()
    {
        return "Shipping to:\n" + _customer.GetName() + "\n" + _customer.GetAddress().DisplayAddress();
        
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
}
