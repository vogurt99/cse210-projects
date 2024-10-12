using System;

class Product
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private int _productQuantity;
    private double _totalProductCost;

    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }
    public string ProductID
    {
        get { return _productID; }
        set { _productID = value; }
    }
    public double ProductPrice
    {
        get { return _productPrice; }
        set { _productPrice = value; }
    }
    public int ProductQuantity
    {
        get { return _productQuantity; }
        set { _productQuantity = value; }
    }
    public double TotalProductCost
    {
        get { return _totalProductCost; }
    }
    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        ProductName = productName;
        ProductID = productID;
        ProductPrice = productPrice;
        ProductQuantity = productQuantity;

        CalculateTotalCost();
    }
    private void CalculateTotalCost()
    {
        _totalProductCost = _productPrice * _productQuantity;
    }
    public void DisplayProduct()
    {
        Console.WriteLine($"\nProduct Name: {ProductName}");
        Console.WriteLine($"Product ID: {ProductID}");
        Console.WriteLine($"Price: ${ProductPrice} * {ProductQuantity} = ${TotalProductCost}");
    }
}