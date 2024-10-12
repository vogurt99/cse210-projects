using System;

class Order
{
    private double _totalOrderCost;
    private Customer _customer;
    private List<Product> _products;
    public double TotalOrderCost
    {
        get { return _totalOrderCost; }
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public void CalculateTotalOrderCost()
    {
        _totalOrderCost = 0;
        foreach (var product in _products)
        {
            _totalOrderCost += product.TotalProductCost;
        }

        if (_customer.CustomerAddress.LivesInUSA())
        {
            _totalOrderCost += 5;
        }
        else
        {
            _totalOrderCost += 35;
        }

        _totalOrderCost = Math.Round(_totalOrderCost, 2);
    }
    public void GeneratePackingLabel()
    {
        Console.WriteLine("Packing Label:");
        foreach (var product in _products)
        {
            Console.WriteLine($"Product Name: {product.ProductName} - Product ID: {product.ProductID}: {product.ProductPrice} * {product.ProductQuantity}");
        }
    }
    public void GenerateShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Customer Name: {_customer.CustomerName}");
        Console.WriteLine($"Address: {_customer.CustomerAddress.GetFullAddress()}");
    }
    public void DisplayOrderDetails()
    {
        _customer.DisplayCustomer();
        Console.WriteLine($"\nTotal Order Cost: ${TotalOrderCost}");
        GeneratePackingLabel();
        GenerateShippingLabel();
        Console.WriteLine();
    }
}
