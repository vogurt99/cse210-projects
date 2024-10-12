using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _livesInUSA;

    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    public string Country
    {
        get { return _country; }
        set { _country = value; }
    }
    public Address(string streetAddress, string city, string state, string country, bool livesInUSA)
    {
        StreetAddress = streetAddress;
        City = city;
        State = state;
        Country = country;
        _livesInUSA = livesInUSA;
    }
    public bool LivesInUSA()
    {
        return _livesInUSA;
    }
    public string GetFullAddress()
    {
        return $"{StreetAddress}, {City}, {State}, {Country}";
    }

}