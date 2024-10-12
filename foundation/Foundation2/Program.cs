using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123, Test Street", "San Juan", "Metro Manila", "Philippines", false);
        Customer customer1 = new Customer("Jericho Gomez", address1);
        List<Product> productsForOrder1 = new List<Product>
        {
            new Product("Product 1", "EX123", 14.99, 5),
            new Product("Product 2", "EX456", 3.99, 2)
        };
        Order order1 = new Order(customer1, productsForOrder1);
        orders.Add(order1);

        Address address2 = new Address("456, Another Street", "New York", "New York", "USA", true);
        Customer customer2 = new Customer("Alice Johnson", address2);
        List<Product> productsForOrder2 = new List<Product>
        {
            new Product("Product 3", "EX789", 32.99, 1),
            new Product("Product 4", "EX101", 9.99, 4),
            new Product("Product 4", "EX102", 3.99, 2)
        };
        Order order2 = new Order(customer2, productsForOrder2);
        orders.Add(order2);

        foreach (var order in orders)
        {
            order.CalculateTotalOrderCost();
            order.DisplayOrderDetails();
        }
    }
}