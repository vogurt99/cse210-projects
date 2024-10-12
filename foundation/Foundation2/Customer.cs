using System;

class Customer
{
    private string  _customerName;
    private Address _customerAddress;

    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }
    public Address CustomerAddress
    {
        get { return _customerAddress; }
        set { _customerAddress = value; }
    }
    public Customer(string customerName, Address customerAddress)
    {
        CustomerName = customerName;
        CustomerAddress = customerAddress;
    }
    public void DisplayCustomer()
    {
        Console.WriteLine($"Customer: {CustomerName} - {CustomerAddress.GetFullAddress()}");
    }
}