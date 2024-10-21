using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("45 Square St", "New York", "NY", "USA");
        Address address2 = new Address("456 Simon Bolivar", "Barranquilla", "Atlantico", "Colombia");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Laptop", 345, 1400.0, 6);
        Product product2 = new Product("Mouse", 110, 25.0, 4);

        Product product3 = new Product("Phone", 201, 800.0, 3);
        Product product4 = new Product("Charger", 220, 15.0, 3);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Price: ${order1.TotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Price: ${order2.TotalCost():0.00}");

    }
}
